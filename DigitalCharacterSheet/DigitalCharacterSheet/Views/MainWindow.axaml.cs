using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DigitalCharacterSheet.ViewModels;

namespace DigitalCharacterSheet.Views;

public partial class MainWindow : Window
{
    private Character.Character _character;

    private MainViewModel _mainViewModel;
    
    public MainWindow()
    {
        InitializeComponent();

        this.Loaded += (sender, args) => _mainViewModel = DataContext as MainViewModel;
    }

    private void OnStatLostFocus(object? sender, RoutedEventArgs e)
    {
        _mainViewModel.UpdateStat();
    }
}
