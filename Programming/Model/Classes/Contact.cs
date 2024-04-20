using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    /// <summary>
    /// Хранит данные о человеке и его контактных данных.
    /// </summary>
class Contact
{
    /// <summary>
    /// Имя для всех объектов класса
    /// </summary>
    private string _name;
    /// <summary>
    /// Фамилия для всех объектов класса
    /// </summary>
    private string _surname;
    /// <summary>
    /// Номер телефона для всех объектов класса
    /// </summary>
    private string _phoneNum;
    /// <summary>
    /// Электронная почта для всех объектов класса
    /// </summary>
    private string _email;

        /// <summary>
        /// Проверяет, состоит ли строка только из символов.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Ошибка, появляющаяся если строка не отвечает свойствам поля</exception>
    private void AssertStringContainsOnlyLetters(string value, string propertyName)
    {
        foreach (char c in value)
        {
            if (!char.IsLetter(c))
            {
                throw new ArgumentException($"The value \"{value}\" is invalid for property \"{propertyName}\". It contains non-alphabetic characters.");
            }
        }
    }
        /// <summary>
        /// Возвращает и задает имя человека. Должна содержать только буквы.
        /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Name));
            _name = value;
        }
    }
    /// <summary>
    /// Возвращает и задает фамилию человека. Должна содержать только буквы.
    /// </summary>
    public string Surname
    {
        get { return _surname; }
        set {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }
    /// <summary>
    /// Возвращает и задает номер телефона человека.
    /// </summary>
    public string PhoneNum
    {
        get
        {
            return _phoneNum;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number cannot be empty or null");
            _phoneNum = value;
        }
    }
    /// <summary>
    /// Возвращает и задает электронную почту человека.
    /// </summary>
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty or null");
            _email = value;
        }
    }
    /// <summary>
    /// Создает экземлпяр класса <see cref="Contact"/>
    /// </summary>
    /// <param name="name">Имя. Должно состоять только из букв.</param>
    /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="email">Электронная почта</param>
    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Name = name;
        Surname = surname;
        PhoneNum = phoneNumber;
        Email = email;
    }
    public Contact() { }
}