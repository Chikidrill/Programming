using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

class Contact
{
    private string _name;
    private string _phoneNum;
    private string _email;
    public string Name
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
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNum = phoneNumber;
        Email = email;
    }
    public Contact() { }
}