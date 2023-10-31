using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Discord_Lite.Assets;
using Discord_Lite.Views;

namespace Discord_Lite;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Holder.Children.Add(new LoginView(this));
    }
}