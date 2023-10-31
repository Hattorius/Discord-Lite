using System.ComponentModel;
using Avalonia.Interactivity;
using Discord_Lite.Views;

namespace Discord_Lite.ViewModels;

public class LoginViewModel : INotifyPropertyChanged
{
    public MainWindow? MainWindow;
    private bool _isLoginLoading;
    public bool IsLoginLoading
    {
        get => _isLoginLoading;
        set
        {
            _isLoginLoading = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoginLoading)));
        }
    }
    
    public void OnLoginButtonClick()
    {
        if (IsLoginLoading) return;
        IsLoginLoading = true;
        
        // TODO: Login logic
        MainWindow?.SwitchToMain();

        IsLoginLoading = false;
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
}