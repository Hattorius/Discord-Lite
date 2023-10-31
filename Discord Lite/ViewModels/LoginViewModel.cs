using System.ComponentModel;
using Avalonia.Interactivity;

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

    private bool _deBounce;
    
    public void OnLoginButtonClick()
    {
        if (_deBounce) return;
        _deBounce = true;
        IsLoginLoading = true;
        
        // TODO: Login logic

        _deBounce = false;
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
}