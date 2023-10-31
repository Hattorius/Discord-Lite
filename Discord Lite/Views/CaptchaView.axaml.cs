using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Discord_Lite.ViewModels;

namespace Discord_Lite.Views;

public partial class CaptchaView : ModalUserControl
{
    public CaptchaView(MainWindow mainWindow)
    {
        InitializeComponent();
        DataContext = new CaptchaViewModel()
        {
            MainWindow = mainWindow
        };
    }
}