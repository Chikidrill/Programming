namespace Contacts.Model
{
    /// <summary>
    /// Класс, описывающий контакт с именем, номером телефона и электронной почтой.
    /// </summary>
    public class Contact
    {

        private string _phoneNumber;
        private string _name;
        private string _email;

        /// <summary>
        /// Получает или задает номер телефона.
        /// </summary>
        public string PhoneNumber {  get { return _phoneNumber; } set { _phoneNumber = value; } }

        /// <summary>
        /// Получает или задает имя контакта.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// Получает или задает адрес электронной почты.
        /// </summary>
        public string Email { get { return _email; } set { _email = value; } }

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
}
