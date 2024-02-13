using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

class Contact
{
    private string Name
    {
        get
        {
            return Name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or null");
            Name = value;
        }
    }
    private string PhoneNum
    {
        get
        {
            return PhoneNum;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number cannot be empty or null");
            PhoneNum = value;
        }
    }
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNum = phoneNumber;
    }
    public Contact()
    {

    }
}