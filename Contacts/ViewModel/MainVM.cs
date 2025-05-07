using Services;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel;

/// <summary>
/// ViewModel главного окна приложения для работы с контактами
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Сериализатор контактов.
    /// </summary>
    private readonly Serializer _contactSerializer;

    /// <summary>
    /// Коллекция контактов.
    /// </summary>
    private readonly ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Выбранный контакт.
    /// </summary>
    private Contact _selectedContact;

    /// <summary>
    /// Клонированный контакт.
    /// </summary>
    private Contact _clonedContact;

    /// <summary>
    /// Видимость кнопки применения изменений.
    /// </summary>
    private bool _isApplyButtonVisible;

    /// <summary>
    /// Флаг, указывающий является ли контакт доступным только для чтения. По умолчанию "true".
    /// </summary>
    private bool _isContactReadOnly = true;

    /// <summary>
    /// Флаг, указывающий, были ли изменены данные
    /// </summary>
    private bool _isDataChanged;

    /// <summary>
    ///  Флаг, показывающий, был ли активирован или нет режим создания нового контакта
    /// </summary>
    private bool _isAddingNewContact;

    /// <summary>
    ///  Флаг, показывающий, является ли выбранный контакт валидным
    /// </summary>
    private bool _isSelectedContactValid = true;

    /// <summary>
    /// Флаг, показывающий, был ли активирован режим редактирования контакта
    /// </summary>
    private bool _isEditingContact;

    /// <summary>
    /// Индекс контакта до начала редактирования.
    /// </summary>
    private int _indexBeforeEditing;

    /// <summary>
    /// Событие, которое вызывается при изменении значения свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Коллекция контактов, которые управляются в приложении.
    /// </summary>
    public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

    /// <summary>
    /// Проверяет, выбран ли контакт.
    /// </summary>
    public bool IsContactSelected => SelectedContact != null;

    /// <summary>
    ///  Проверяет, могут ли быть применены изменения 
    /// </summary>
    public bool CanApply => IsDataChanged && IsSelectedContactValid;

    /// <summary>
    /// Выбранный контакт.
    /// </summary>
    public Contact SelectedContact
    {
        get => _selectedContact;
        set
        {
            if (_selectedContact != value)
            {
                if (_isAddingNewContact && _selectedContact != null && !Contacts.Contains(_selectedContact))
                {
                    _isAddingNewContact = false;
                }
                if (_isEditingContact && _clonedContact != null && _selectedContact != null)
                {
                    _selectedContact = new Contact(_clonedContact);
                }

                if (_selectedContact != null)
                    _selectedContact.PropertyChanged -= OnContactPropertyChanged;

                _selectedContact = value;

                if (_selectedContact != null)
                    _selectedContact.PropertyChanged += OnContactPropertyChanged;

                IsDataChanged = false;
                IsApplyButtonVisible = false;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsContactSelected));

                if (_selectedContact != null)
                {
                    IsContactReadOnly = true;
                    IsApplyButtonVisible = false;
                }

                _isEditingContact = false;
                _clonedContact = null;
                ValidateCurrentContact();
            }
        }
    }

    /// <summary>
    /// Видимость кнопки "Применить", которая зависит от того, были ли изменения в данных.
    /// </summary>
    public bool IsApplyButtonVisible
    {
        get { return _isApplyButtonVisible; }
        set
        {
            if (_isApplyButtonVisible != value)
            {
                _isApplyButtonVisible = value;
                OnPropertyChanged(nameof(IsApplyButtonVisible));
            }
        }
    }

    /// <summary>
    /// Флаг, показывающий, был ли активирован или нет режим создания нового пользователя
    /// </summary>
    public bool IsAddingNewContact
    {
        get => _isAddingNewContact;
        set
        {
            if (_isAddingNewContact != value)
            {
                _isAddingNewContact = value;
                OnPropertyChanged();
            }
        }
    }

    /// <summary>
    /// Флаг, показывающий, были ли изменения в данных, которые требуют сохранения.
    /// </summary>
    public bool IsDataChanged
    {
        get => _isDataChanged;
        set
        {
            if (_isDataChanged != value)
            {
                _isDataChanged = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CanApply));
            }
        }
    }

    /// <summary>
    /// Устанавливает режим "только для чтения" для редактирования контакта.
    /// </summary>
    public bool IsContactReadOnly
    {
        get => _isContactReadOnly;
        set
        {
            if (_isContactReadOnly != value)
            {
                _isContactReadOnly = value;
                OnPropertyChanged();
            }
        }
    }

    /// <summary>
    /// Команда для добавления нового контакта.
    /// </summary>
    public RelayCommand AddCommand { get; }

    /// <summary>
    /// Команда для редактирования выбранного контакта.
    /// </summary>
    public RelayCommand EditCommand { get; }

    /// <summary>
    /// Команда для удаления выбранного контакта.
    /// </summary>
    public RelayCommand RemoveCommand { get; }

    /// <summary>
    /// Команда для применения изменений контакта.
    /// </summary>
    public RelayCommand ApplyCommand { get; }

    /// <summary>
    /// Получает или задаёт значение, указывающее, является ли выбранный контакт валидным.
    /// </summary>
    public bool IsSelectedContactValid
    {
        get => _isSelectedContactValid;
        set
        {
            if (_isSelectedContactValid != value)
            {
                _isSelectedContactValid = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CanApply));
            }
        }
    }

    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя свойства, которое изменилось.</param>
    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
    /// Добавляет новый контакт в коллекцию.
    /// </summary>
    private void AddContact(object parameter)
    {
        IsContactReadOnly = false;
        _isAddingNewContact = true;
        var newContact = new Contact();
        SelectedContact = newContact;
        UpdateContact(newContact);
        IsApplyButtonVisible = true;
    }

    /// <summary>
    /// Разрешает редактирование выбранного контакта.
    /// </summary>
    private void EditContact(object parameter)
    {
        if (SelectedContact != null)
        {
            _clonedContact = new Contact(SelectedContact);

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
    private void RemoveContact(object parameter)
    {
        if (SelectedContact != null)
        {
            int selectedIndex = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            _contactSerializer.Save(Contacts);

            if (Contacts.Count > 0)
            {
                if (selectedIndex < Contacts.Count)
                {
                    SelectedContact = Contacts[selectedIndex];
                }
                else
                {
                    SelectedContact = Contacts[Contacts.Count - 1];
                }
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
    private void ApplyChanges(object parameter)
    {
        if (SelectedContact != null && CanApply)
        {
            if (_isAddingNewContact)
            {
                if (!Contacts.Contains(SelectedContact))
                {
                    Contacts.Add(SelectedContact);
                }
                _isAddingNewContact = false;
            }
            else if (_isEditingContact)
            {
                var contactToUpdate = Contacts[_indexBeforeEditing];
                contactToUpdate.Name = SelectedContact.Name;
                contactToUpdate.Number = SelectedContact.Number;
                contactToUpdate.Email = SelectedContact.Email;

                _isEditingContact = false;
            }

            _contactSerializer.Save(Contacts);
            IsDataChanged = false;
            IsContactReadOnly = true;
            IsApplyButtonVisible = false;
            _clonedContact = null;
        }
    }

    /// <summary>
    /// Проверяет валидность контакта
    /// </summary>
    public bool IsContactValid(Contact contact)
    {
        return contact?.Error == string.Empty;
    }

    /// <summary>
    /// Проверяет, можно ли редактировать или удалить контакт.
    /// </summary>
    public bool CanEditOrRemoveContact(object parameter)
    {
        return SelectedContact != null && Contacts.Count > 0;
    }

    /// <summary>
    /// Сохраняет контакты
    /// </summary>
    public void SaveContacts()
    {
        _contactSerializer.Save(Contacts);
    }

    /// <summary>
    /// Выполняет проверку текущего контакта и обновляет флаг IsSelectedContactValid.
    /// </summary>
    public void ValidateCurrentContact()
    {
        IsSelectedContactValid = IsContactValid(_selectedContact);
    }

    /// <summary>
    /// Обработчик события изменения свойства контакта.
    /// Выполняет валидацию текущего контакта при изменении его свойств.
    /// </summary>
    /// <param name="sender">Объект, который вызвал событие.</param>
    /// <param name="e">Событие, содержащее информацию о изменённом свойстве.</param>
    public void OnContactPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        ValidateCurrentContact();
    }

    /// <summary>
    /// Инициализирует ViewModel и загружает контакты с помощью сериализатора.
    /// </summary>
    public MainVM()
    {
        _contactSerializer = new Serializer();
        var loadedContacts = _contactSerializer.Load() ?? new List<Contact>();
        Contacts = new ObservableCollection<Contact>(loadedContacts);
        AddCommand = new RelayCommand(AddContact);
        EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
        RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
        ApplyCommand = new RelayCommand(ApplyChanges, _ => CanApply);
    }
}