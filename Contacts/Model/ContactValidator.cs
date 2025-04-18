using System.Text.RegularExpressions;

namespace Model;
public class ContactValidator
{
    private static readonly Regex PhoneRegex = new Regex(@"^\+7-\d{3}-\d{3}-\d{2}-\d{2}", RegexOptions.Compiled);
    private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    public static string ValidateName(string name)
    {
        return string.IsNullOrWhiteSpace(name) ? "Name cannot be empty" : null;
    }

    public static string ValidateEmail(string email)
    {
        return EmailRegex.IsMatch(email) ? null : "Invalid email format";
    }

    public static string ValidatePhoneNumber(string phoneNumber)
    {
        return PhoneRegex.IsMatch(phoneNumber) ? null : "Phone number must be in format +7-XXX-XXX-XX-XX.";
    }
    public static bool ValidateContact(Contact contact, out string errorMessage)
    {
        errorMessage = ValidateName(contact.Name) ??
                        ValidatePhoneNumber(contact.PhoneNumber) ??
                        ValidateEmail(contact.Email);
        return errorMessage == null;
    }
}

