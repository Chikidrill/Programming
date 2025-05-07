using Contacts.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Contacts.View.Controls;

/// <summary>
/// Логика взаимодействия для ContactControl.xaml
/// </summary>
public partial class ContactControl : UserControl
{
    /// <summary>
    /// Регистрирует зависимость свойства IsReadOnly для ContactControl.
    /// По умолчанию значение — true.
    /// </summary>
    public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(ContactControl), new PropertyMetadata(true));

    /// <summary>
    /// Определяет, доступен ли только для чтения интерфейс ContactControl.
    /// При true — поля недоступны для редактирования.
    /// </summary>
    public bool IsReadOnly
    {
        get => (bool)GetValue(IsReadOnlyProperty);
        set => SetValue(IsReadOnlyProperty, value);
    }

    /// <summary>
    /// Обрабатывает ввод текста в поле номера телефона.
    /// Разрешает ввод только цифр, символов '+', '(', ')', '-' и пробелов.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события, содержащие введённый текст.</param>
    private void PhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        var textBox = sender as TextBox;
        var newText = textBox.Text.Insert(textBox.CaretIndex, e.Text);
        if (!Contact.PhoneNumberMask.IsMatch(newText))
        {
            e.Handled = true;
        }
    }

    /// <summary>
    /// Обрабатывает вставку текста в поле номера телефона.
    /// Запрещает вставку текста, если он содержит недопустимые символы.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события, содержащие вставляемый текст.</param>
    private void PhoneNumber_Pasting(object sender, DataObjectPastingEventArgs e)
    {
        if (!e.DataObject.GetDataPresent(typeof(string)))
        {
            e.CancelCommand();
            return;
        }

        var text = (string)e.DataObject.GetData(typeof(string));
        if (!Contact.PhoneNumberRegex.IsMatch(text))
        {
            e.CancelCommand();
        }
    }
    public ContactControl()
    {
        InitializeComponent();
    }
}