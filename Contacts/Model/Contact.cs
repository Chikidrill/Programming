using System.ComponentModel;

namespace Model;
/// <summary>
/// Класс, описывающий контакт с именем, номером телефона и электронной почтой.
/// </summary>
public class Contact : INotifyPropertyChanged
{
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
    /// Событие, которое вызывается при изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Получает или задает номер телефона.
    /// </summary>
    public string PhoneNumber
    {
        get => _number;
        set
        {
            if (_number != value)
            {
                _number = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
    }

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
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    /// <summary>
    /// Получает или задает адрес электронной почты.
    /// </summary>
    public string Email {
        get => _email;
        set
        {
            if (_email != value)
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
    }

    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя изменившегося свойства.</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с указанными именем, номером телефона и электронной почтой.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="number">Номер телефона контакта.</param>
    /// <param name="email">Электронная почта контакта.</param>
    public Contact(string name, string number, string email)
    {
        Name = name;
        PhoneNumber = number;
        Email = email;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> без параметров.
    /// </summary>
    public Contact() { }
}

