using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace ViewModel;

/// <summary>
/// ViewModel главного окна приложения для работы с контактами
/// </summary>
public partial class MainVM : ObservableObject
{
    private readonly Serializer _contactSerializer;
    private Contact _clonedContact;
    private int _indexBeforeEditing;

    /// <summary>
    /// Коллекция контактов, которые управляются в приложении.
    /// </summary>
    public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

    /// <summary>
    /// Проверяет, выбран ли контакт.
    /// </summary>
    public bool IsContactSelected => SelectedContact != null;

    /// <summary>
    /// Проверяет, могут ли быть применены изменения.
    /// </summary>
    public bool CanApply => IsDataChanged && IsSelectedContactValid;

    /// <summary>
    /// Сериализатор контактов.
    /// </summary>
    [ObservableProperty]
    private Contact selectedContact;

    /// <summary>
    /// Видимость кнопки применения изменений.
    /// </summary>
    [ObservableProperty]
    private bool isApplyButtonVisible;

    /// <summary>
    /// Флаг, указывающий, является ли контакт доступным только для чтения. По умолчанию "true".
    /// </summary>
    [ObservableProperty]
    private bool isContactReadOnly = true;

    /// <summary>
    /// Флаг, указывающий, были ли изменены данные.
    /// </summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanApply))]
    [NotifyCanExecuteChangedFor(nameof(ApplyChangesCommand))]
    private bool isDataChanged;

    /// <summary>
    /// Флаг, показывающий, был ли активирован или нет режим создания нового контакта.
    /// </summary>
    [ObservableProperty]
    private bool isAddingNewContact;

    /// <summary>
    /// Флаг, показывающий, является ли выбранный контакт валидным.
    /// </summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanApply))]
    [NotifyCanExecuteChangedFor(nameof(ApplyChangesCommand))]
    private bool isSelectedContactValid = true;

    /// <summary>
    /// Флаг, показывающий, был ли активирован режим редактирования контакта.
    /// </summary>
    private bool _isEditingContact;

    /// <summary>
    /// Обработчик изменения выбранного контакта.
    /// Вызывается автоматически при изменении свойства SelectedContact.
    /// </summary>
    /// <param name="value">Новое значение выбранного контакта</param>
    partial void OnSelectedContactChanged(Contact value)
    {
        if (value != null)
        {
            IsContactReadOnly = true;
            IsApplyButtonVisible = false;
        }

        if (SelectedContact != null)
            SelectedContact.PropertyChanged -= OnContactPropertyChanged;

        SelectedContact = value;

        if (SelectedContact != null)
            SelectedContact.PropertyChanged += OnContactPropertyChanged;

        IsDataChanged = false;
        IsApplyButtonVisible = false;
        OnPropertyChanged(nameof(IsContactSelected));

        // Уведомляем команды о необходимости перепроверить CanExecute
        EditContactCommand.NotifyCanExecuteChanged();
        RemoveContactCommand.NotifyCanExecuteChanged();

        _isEditingContact = false;
        _clonedContact = null;
        ValidateCurrentContact();
    }

    /// <summary>
    /// Добавляет новый контакт в коллекцию.
    /// </summary>
    [RelayCommand]
    private void AddContact()
    {
        IsContactReadOnly = false;
        IsAddingNewContact = true;
        var newContact = new Contact();
        SelectedContact = newContact;
        UpdateContact(newContact);
        IsApplyButtonVisible = true;
    }

    /// <summary>
    /// Разрешает редактирование выбранного контакта.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
    private void EditContact()
    {
        if (SelectedContact != null)
        {
            _clonedContact = SelectedContact; 
            _indexBeforeEditing = Contacts.IndexOf(SelectedContact);

            SelectedContact = new Contact(_clonedContact);

            _isEditingContact = true;
            UpdateContact(SelectedContact);
            IsContactReadOnly = false;
            IsApplyButtonVisible = true;
        }
    }

    /// <summary>
    /// Удаляет выбранный контакт из коллекции.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
    private void RemoveContact()
    {
        if (SelectedContact != null)
        {
            int selectedIndex = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            _contactSerializer.Save(Contacts);

            if (Contacts.Count > 0)
            {
                SelectedContact = selectedIndex < Contacts.Count ? Contacts[selectedIndex] : Contacts[^1];
            }
            else
            {
                SelectedContact = null;
            }
        }
    }

    /// <summary>
    /// Применяет изменения и сохраняет обновленные контакты.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanApply))]
    private void ApplyChanges()
    {
        if (SelectedContact != null)
        {
            if (IsAddingNewContact)
            {
                if (!Contacts.Contains(SelectedContact))
                {
                    Contacts.Add(SelectedContact);
                }
                IsAddingNewContact = false;
            }
            else if (_isEditingContact)
            {
                Contacts[_indexBeforeEditing] = SelectedContact;
                _isEditingContact = false;
            }

            _contactSerializer.Save(Contacts);
            IsDataChanged = false;
            IsContactReadOnly = true;
            IsApplyButtonVisible = false;
            _clonedContact = null;

            OnPropertyChanged(nameof(Contacts));
        }
    }

    /// <summary>
    /// Обновляет контакт, устанавливая флаг изменений данных и разрешая редактирование.
    /// </summary>
    private void UpdateContact(Contact contact)
    {
        IsDataChanged = true;
        IsContactReadOnly = false;
    }

    /// <summary>
    /// Проверяет валидность контакта.
    /// </summary>
    public bool IsContactValid(Contact contact) => contact?.Error == string.Empty;

    /// <summary>
    /// Проверяет, можно ли редактировать или удалить контакт.
    /// </summary>
    public bool CanEditOrRemoveContact() => SelectedContact != null && Contacts.Count > 0;

    /// <summary>
    /// Сохраняет контакты.
    /// </summary>
    public void SaveContacts() => _contactSerializer.Save(Contacts);

    /// <summary>
    /// Выполняет проверку текущего контакта и обновляет флаг IsSelectedContactValid.
    /// </summary>
    public void ValidateCurrentContact() => IsSelectedContactValid = IsContactValid(SelectedContact);

    /// <summary>
    /// Обработчик события изменения свойства контакта. Выполняет валидацию текущего контакта при изменении его свойств.
    /// </summary>
    public void OnContactPropertyChanged(object sender, PropertyChangedEventArgs e) => ValidateCurrentContact();

    /// <summary>
    /// Инициализирует ViewModel и загружает контакты с помощью сериализатора.
    /// </summary>
    public MainVM()
    {
        _contactSerializer = new Serializer();
        var loadedContacts = _contactSerializer.Load() ?? new List<Contact>();
        Contacts = new ObservableCollection<Contact>(loadedContacts);
    }
}
