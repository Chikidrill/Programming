using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

class Contact
{
    private string _name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or null");
            _name = value;
        }
    }
    private string _phoneNum
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
    private string _email
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
    public Contact(string Name, string PhoneNumber, string Email)
    {
        _name = Name;
        _phoneNum = PhoneNumber;
        _email = Email;
    }
}