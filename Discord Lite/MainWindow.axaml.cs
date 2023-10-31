using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Discord_Lite.Assets;
using Discord_Lite.Views;

namespace Discord_Lite;

public partial class MainWindow : Window
{
    private AppView _appView;
    
    public MainWindow()
    {
        InitializeComponent();
        _appView = new AppView();
        ContentHolder.Children.Add(new LoginView(this));
    }

    public void SwitchToMain()
    {
        ContentHolder.Children.Clear();
        ContentHolder.Children.Add(_appView);
    }
}