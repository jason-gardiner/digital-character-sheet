using System;
using System.ComponentModel;
using Avalonia.Interactivity;
using DigitalCharacterSheet.Utilities;

namespace DigitalCharacterSheet.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
#region CharacterStatAccessors

    #region Strength
    public string StrengthText
    {
        get => _strengthText;
        set
        {
            _strengthText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Strength = value.ToPureInt();
            NotifyPropertyChanged();
        }
    }
    private string _strengthText = "10";
    
    public string StrengthModifier
    {
        get => _strengthModifier;
        set
        {
            _strengthModifier = value;
            NotifyPropertyChanged();
        }
    }
    private string _strengthModifier = "0";
    #endregion
    #region Dexterity
    public string DexterityText {
        get => _dexterityText;
        set {
            _dexterityText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Dexterity = value.ToPureInt();
            
            NotifyPropertyChanged();
        }
    }
    private string _dexterityText = "10";
    
    public string DexterityModifier
    {
        get => _dexterityModifier;
        set
        {
            _dexterityText = value;
            NotifyPropertyChanged();
        }
    }
    private string _dexterityModifier = "0";
    #endregion
    #region Constitution
    public string ConstitutionText {
        get => _constitutionText;
        set {
            _constitutionText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Constitution = value.ToPureInt();
            ConstitutionModifier = App.LoadedCharacter.CharacterStats.ConstitutionModifier.ToString();
            NotifyPropertyChanged();
        }
    }
    private string _constitutionText = "10";
    
    public string ConstitutionModifier
    {
        get => _constitutionModifier;
        set
        {
            _constitutionModifier = value;
            NotifyPropertyChanged();
        }
    }
    private string _constitutionModifier = "0";
    #endregion
    #region  Intelligence
    public string IntelligenceText
    {
        get => _intelligenceText;
        set
        {
            _intelligenceText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Intelligence = value.ToPureInt();
            
            NotifyPropertyChanged();
        }
    }
    private string _intelligenceText = "10";
    
    public string IntelligenceModifier
    {
        get => _intelligenceModifier;
        set
        {
            _intelligenceModifier = value;
            NotifyPropertyChanged();
        }
    }
    private string _intelligenceModifier = "0";
    #endregion
    #region  Wisdom
    public string WisdomText
    {
        get => _wisdomText;
        set
        {
            _wisdomText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Wisdom = value.ToPureInt();
            NotifyPropertyChanged();
        }
    }
    private string _wisdomText = "10";
    
    public string WisdomModifier
    {
        get => _wisdomModifier;
        set
        {
            _wisdomModifier = value;
            NotifyPropertyChanged();
        }
    }
    private string _wisdomModifier = "0";
    #endregion
    #region  Charisma
    public string CharismaText
    {
        get => _charismaText;
        set
        {
            _charismaText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Charisma = value.ToPureInt();
            NotifyPropertyChanged();
        }
    }
    private string _charismaText = "10";
    
    public string CharismaModifier
    {
        get => _charismaModifier;
        set
        {
            _charismaModifier = value;
            NotifyPropertyChanged();
        }
    }
    private string _charismaModifier = "0";
    #endregion
    
    public void UpdateStat()
    {
        StrengthText = App.LoadedCharacter.CharacterStats.Strength.ToString();
        StrengthModifier = App.LoadedCharacter.CharacterStats.StrengthModifier.ToString();
        
        DexterityText = App.LoadedCharacter.CharacterStats.Dexterity.ToString();
        DexterityModifier = App.LoadedCharacter.CharacterStats.DexterityModifier.ToString();
        
        ConstitutionText = App.LoadedCharacter.CharacterStats.Constitution.ToString();
        ConstitutionModifier = App.LoadedCharacter.CharacterStats.ConstitutionModifier.ToString();
        
        IntelligenceText = App.LoadedCharacter.CharacterStats.Intelligence.ToString();
        IntelligenceModifier = App.LoadedCharacter.CharacterStats.IntelligenceModifier.ToString();
        
        WisdomText = App.LoadedCharacter.CharacterStats.Wisdom.ToString();
        WisdomModifier = App.LoadedCharacter.CharacterStats.WisdomModifier.ToString();
        
        CharismaText = App.LoadedCharacter.CharacterStats.Charisma.ToString();
        CharismaModifier = App.LoadedCharacter.CharacterStats.CharismaModifier.ToString();
    }
    
#endregion

#region Skills

#endregion

    public string Level {
        get => App.LoadedCharacter.Level.ToString();
        set
        {
            App.LoadedCharacter.Level = value.ToPureInt();
            NotifyPropertyChanged();
        }
    }
}