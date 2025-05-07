using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Contacts.Model;
/// <summary>
/// Класс, описывающий контакт с именем, номером телефона и электронной почтой.
/// </summary>
public class Contact : ObservableObject, IDataErrorInfo
{

    /// <summary>
    /// Событие, которое вызывается при изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Имя контакта
    /// </summary>
    private string _name;

    /// <summary>
    /// Номер телефона контакта
    /// </summary>
    private string _number;

    /// <summary>
    /// Электронная почта контакта
    /// </summary>
    private string _email;

    /// <summary>
    /// Словарь ошибок
    /// </summary>
    private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();


    /// <summary>
    /// Максимальная длина имени контакта.
    /// </summary>
    private const int MaxNameLength = 100;

    /// <summary>
    /// Максимальная длина номера телефона.
    /// </summary>
    private const int MaxPhoneNumberLength = 100;

    /// <summary>
    /// Максимальная длина электронной почты.
    /// </summary>
    private const int MaxEmailLength = 100;

    /// <summary>
    /// Регулярное выражение для маски ввода номера телефона.
    /// </summary>
    public static readonly Regex PhoneNumberMask = new Regex(@"^[0-9+() -]*$");

    /// <summary>
    /// Регулярное выражение для проверки корректности номера телефона.
    /// </summary>
    public static readonly Regex PhoneNumberRegex =
        new Regex(@"^\+?(\d{1,3})?[-. (]*(\d{1,4})[-. )]*(\d{1,4})[-. ]*(\d{1,9})$");

    /// <summary>
    /// Регулярное выражение для проверки корректности электронной почты.
    /// </summary>
    public static readonly Regex EmailRegex =
        new Regex(@"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$");

    /// <summary>
    /// Получает или задает имя контакта.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                ValidateProperty(nameof(Name), value);
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    /// <summary>
    /// Получает или задает номер телефона контакта.
    /// </summary>
    public string Number
    {
        get => _number;
        set
        {
            if (_number != value)
            {
                _number = value;
                ValidateProperty(nameof(Number), value);
                OnPropertyChanged(nameof(Number));
            }
        }
    }

    /// <summary>
    /// Получает или задает электронную почту контакта.
    /// </summary>
    public string Email
    {
        get => _email;
        set
        {
            if (_email != value)
            {
                _email = value;
                ValidateProperty(nameof(Email), value);
                OnPropertyChanged(nameof(Email));
            }
        }
    }

    /// <summary>
    /// Получает все ошибки валидации, объединенные в одну строку.
    /// </summary>
    public string Error => string.Join("\n", _errors.Values);


    /// <summary>
    /// Получает сообщение об ошибке для указанного свойства.
    /// </summary>
    /// <param name="columnName">Имя свойства для проверки.</param>
    /// <returns>Сообщение об ошибке или null, если ошибок нет.</returns>
    public string this[string columnName] => _errors.TryGetValue(columnName, out var error) ? error : null;


    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя изменившегося свойства.</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Проверяет значение свойства и сохраняет ошибку валидации, если она есть.
    /// </summary>
    /// <param name="propertyName">Имя проверяемого свойства.</param>
    /// <param name="value">Значение свойства.</param>
    private void ValidateProperty(string propertyName, string value)
    {
        string error = null;

        switch (propertyName)
        {
            case nameof(Name):
                if (string.IsNullOrWhiteSpace(value))
                    error = "Имя не может быть пустым.";
                else if (value.Length > MaxNameLength)
                    error = "Имя не должно превышать 100 символов.";
                break;

            case nameof(_number):
                if (string.IsNullOrWhiteSpace(value))
                {
                    error = "Номер телефона не может быть пустым.";
                }
                else
                {
                    if (!PhoneNumberMask.IsMatch(value))
                        error = "Номер телефона содержит недопустимые символы.";
                    else if (value.Length > MaxPhoneNumberLength)
                        error = "Номер телефона не должен превышать 100 символов.";
                    else if (!PhoneNumberRegex.IsMatch(value))
                        error = "Номер телефона имеет неверный формат. Пример: +7 (123) 456-7890";
                }
                break;

            case nameof(Email):
                if (string.IsNullOrWhiteSpace(value))
                {
                    error = "Email не может быть пустым.";
                }
                else
                {
                    if (value.Length > MaxEmailLength)
                        error = "Email не должен превышать 100 символов.";
                    else if (!EmailRegex.IsMatch(value))
                        error = "Email имеет неверный формат. Пример: example@domain.com";
                }
                break;
        }

        if (error != null)
            _errors[propertyName] = error;
        else
            _errors.Remove(propertyName);
    }


    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с указанными именем,
    /// номером телефона и электронной почтой.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="number">Номер телефона контакта.</param>
    /// <param name="email">Электронная почта контакта.</param>
    public Contact(string name, string number, string email)
    {
        Name = name;
        Number = number;
        Email = email;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> без параметров.
    /// </summary>
    public Contact() { }

    public Contact(Contact contact)
    {
        Name = contact.Name;
        Number = contact.Number;
        Email = contact.Email;
    }
}


