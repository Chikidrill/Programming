/// <summary>
/// Класс, описывающий контакт с именем, номером телефона и электронной почтой.
/// </summary>
public class Contact
{
    /// <summary>
    /// Получает или задает номер телефона.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Получает или задает имя контакта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Получает или задает адрес электронной почты.
    /// </summary>
    public string Email { get; set; }

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

