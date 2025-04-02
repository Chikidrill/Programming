using Contacts.ViewModel;
using System.Windows;
namespace Contacts;

/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainVM();
    }
}

