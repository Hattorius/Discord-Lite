using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Discord_Lite.ViewModels;

namespace Discord_Lite.Views;

public partial class LoginView : UserControl
{
    public LoginView(MainWindow mainWindow)
    {
        InitializeComponent();
        DataContext = new LoginViewModel()
        {
            MainWindow = mainWindow
        };
    }
}