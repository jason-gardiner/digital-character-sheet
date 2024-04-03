using System;
using System.ComponentModel;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.Input;

namespace DigitalCharacterSheet.ViewModels;
using Character;
using Utilities;

public class MainViewModel : ViewModelBase
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

    private void OnStrengthTextChanged()
    {
        
    }

    public MainViewModel()
    {
        StrengthChanged = new RelayCommand(OnStrengthTextChanged);
    }
}
