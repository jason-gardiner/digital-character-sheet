using System;
using System.ComponentModel;
using Avalonia.Interactivity;
using DigitalCharacterSheet.Utilities;

namespace DigitalCharacterSheet.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    #region CharacterStatAccessors
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
    public string StrengthModText
    {
        get => Character.CharacterStats.StrengthModifier.ToString();
        set => Console.WriteLine(value);
    }

    public string DexterityScoreText {
        get => Character.CharacterStats.Dexterity.ToString();
        set => Character.CharacterStats.Dexterity = value.RemoveNonNumerics();
    }
    public string ConstitutionScoreText {
        get => Character.CharacterStats.Constitution.ToString();
        set => Character.CharacterStats.Constitution = value.RemoveNonNumerics();
    }
    public string IntelligenceScoreText {
        get => Character.CharacterStats.Intelligence.ToString();
        set => Character.CharacterStats.Intelligence = value.RemoveNonNumerics();
    }
    public string WisdomScoreText {
        get => Character.CharacterStats.Wisdom.ToString();
        set => Character.CharacterStats.Wisdom = value.RemoveNonNumerics();
    }
    public string CharismaScoretext {
        get => Character.CharacterStats.Charisma.ToString();
        set => Character.CharacterStats.Charisma = value.RemoveNonNumerics();
    }
    #endregion

    private Character _character = new();
    public Character Character
    {
        get => _character;
        set => _character = value;
    }

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

// Old code, need some of it, so I wanna keep it
/*
 * public class MainViewModel : ViewModelBase
{
    #region CharacterStatAccessors
    public string StrengthScoreText
    {
        get => Character.CharacterStats.Strength.ToString();
        set
        {
            Character.CharacterStats.Strength = value.RemoveNonNumerics();
        }
    }

    public ICommand StrengthChanged { get; set; }

    public string StrengthModText
    {
        get => Character.CharacterStats.StrengthModifier.ToString();
        set => Console.WriteLine(value);
    }

    public string DexterityScoreText {
        get => Character.CharacterStats.Dexterity.ToString();
        set => Character.CharacterStats.Dexterity = value.RemoveNonNumerics();
    }
    public string ConstitutionScoreText {
        get => Character.CharacterStats.Constitution.ToString();
        set => Character.CharacterStats.Constitution = value.RemoveNonNumerics();
    }
    public string IntelligenceScoreText {
        get => Character.CharacterStats.Intelligence.ToString();
        set => Character.CharacterStats.Intelligence = value.RemoveNonNumerics();
    }
    public string WisdomScoreText {
        get => Character.CharacterStats.Wisdom.ToString();
        set => Character.CharacterStats.Wisdom = value.RemoveNonNumerics();
    }
    public string CharismaScoretext {
        get => Character.CharacterStats.Charisma.ToString();
        set => Character.CharacterStats.Charisma = value.RemoveNonNumerics();
    }
    #endregion

    private Character _character = new();
    public Character Character
    {
        get => _character;
        set => _character = value;
    }

    public void OnStrengthTextChanged()
    {
        _character.CharacterStats.Strength = StrengthScoreText.RemoveNonNumerics();
        StrengthScoreText = _character.CharacterStats.Strength.ToString();
    }

    public MainViewModel()
    {
        StrengthChanged = ReactiveCommand.Create(OnStrengthTextChanged);
    }
}
