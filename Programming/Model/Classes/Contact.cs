using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNum;
    private string _email;
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
    public string Surname
    {
        get { return _surname; }
        set {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }
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
    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Name = name;
        Surname = surname;
        PhoneNum = phoneNumber;
        Email = email;
    }
    public Contact() { }
}