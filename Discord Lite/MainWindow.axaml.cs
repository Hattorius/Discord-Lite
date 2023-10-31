using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using Discord_Lite.Assets;
using Discord_Lite.Views;

namespace Discord_Lite;

public partial class MainWindow : Window
{
    private AppView _appView;
    public ModalStack Modals;
    
    public MainWindow()
    {
        InitializeComponent();
        _appView = new AppView();
        Modals = new ModalStack()
        {
            MainWindow = this
        };
        ContentHolder.Children.Add(new LoginView(this));
    }

    public void SwitchToMain()
    {
        ContentHolder.Children.Clear();
        ContentHolder.Children.Add(_appView);
    }

    public void SetCurrentModal(ModalUserControl currentModal)
    {
        ModalHolder.IsVisible = true;
        ModalHolderContent.Children.Clear();
        ModalHolderContent.Children.Add(currentModal);
    }

    public void RemoveModal()
    {
        ModalHolder.IsVisible = false;
        ModalHolderContent.Children.Clear();
    }

    private void ModalHolder_OnTapped(object? sender, TappedEventArgs e)
    {
        if (e.Source.Equals(ModalHolder))
        {
            Modals.CloseCurrentModal();
        }
    }
}