using System.ComponentModel;
using System.Threading.Tasks;
using Avalonia.Interactivity;
using Discord_Lite.Models;
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

    public string DiscordToken { get; set; }
    
    public async Task OnLoginButtonClick()
    {
        if (IsLoginLoading) return;
        IsLoginLoading = true;
        
        // TODO: Login logic
        var discord = new Discord(DiscordToken);
        await discord.GetMe();
        if (discord.IsLoggedIn)
        {
            MainWindow.Discord = discord;
            discord.Start(); // TODO: remove the await modifier
            MainWindow?.SwitchToMain();
        }

        IsLoginLoading = false;
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
}