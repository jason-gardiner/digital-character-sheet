using System;
using System.ComponentModel;
using Avalonia.Interactivity;

namespace DigitalCharacterSheet.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    public string StrengthText
    {
        get => _strengthText;
        set
        {
            _strengthText = value;
            App.LoadedCharacter.CharacterStats.Strength = int.Parse(value);
            StrengthModifier = App.LoadedCharacter.CharacterStats.StrengthModifier.ToString();
            NotifyPropertyChanged(nameof(StrengthText));
        }
    }
    private string _strengthText = "10";
    
    public string StrengthModifier
    {
        get => _strengthModifier;
        set
        {
            _strengthModifier = value;
            NotifyPropertyChanged(nameof(StrengthModifier));
        }
    }

    private string _strengthModifier = "0";

    public void Test()
    {
        Console.WriteLine(StrengthText);
        switch (int.Parse(StrengthText))
        {
            case >= 30:
                StrengthText = "30";
                break;
            case <= 0:
                StrengthText = "0";
                break;
        }
    }
}
