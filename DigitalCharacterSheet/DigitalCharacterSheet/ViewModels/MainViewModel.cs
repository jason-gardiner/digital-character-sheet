using System.ComponentModel;
using DigitalCharacterSheet.Utilities;

namespace DigitalCharacterSheet.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    public string Level
    {
        get => _level;
        set
        {
            _level = value.RemoveNonNumberics();
            App.LoadedCharacter.Level = value.ToPureInt();
            NotifyPropertyChanged();
            
        }
    }

    private string _level = App.LoadedCharacter.Level.ToString();

    public void UpdateLevel()
    {
        Level = App.LoadedCharacter.Level.ToString();
        UpdateSkills();
    }

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

    public string DexterityText
    {
        get => _dexterityText;
        set
        {
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
            _dexterityModifier = value;
            NotifyPropertyChanged();
        }
    }

    private string _dexterityModifier = "0";

    #endregion

    #region Constitution

    public string ConstitutionText
    {
        get => _constitutionText;
        set
        {
            _constitutionText = value.RemoveNonNumberics();
            App.LoadedCharacter.CharacterStats.Constitution = value.ToPureInt();
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

    #region Intelligence

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

    #region Wisdom

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

    #region Charisma

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

        UpdateSkills();
    }

    #endregion

    #region Skills

    #region Athletics

    public bool AthleticsExpertiseChecked
    {
        get => _athleticsExpertiseChecked;
        set
        {
            _athleticsExpertiseChecked = value;
            if (!value && AthleticsProficiencyChecked) AthleticsProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(AthleticsProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _athleticsExpertiseChecked;

    public bool AthleticsProficiencyChecked
    {
        get => _athleticsProficiencyChecked;
        set
        {
            _athleticsProficiencyChecked = value;
            if (value) AthleticsExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _athleticsProficiencyChecked;

    public string AthleticsModifierText =>
        (App.LoadedCharacter.CharacterStats.StrengthModifier +
         GetProficiencyModifier(AthleticsExpertiseChecked, AthleticsProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Acrobatics

    public bool AcrobaticsExpertiseChecked
    {
        get => _acrobaticsExpertiseChecked;
        set
        {
            _acrobaticsExpertiseChecked = value;
            if (!value && AcrobaticsProficiencyChecked) AcrobaticsProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(AcrobaticsProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _acrobaticsExpertiseChecked;

    public bool AcrobaticsProficiencyChecked
    {
        get => _acrobaticsProficiencyChecked;
        set
        {
            _acrobaticsProficiencyChecked = value;
            if (value) AcrobaticsExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _acrobaticsProficiencyChecked;

    public string AcrobaticsModifierText =>
        (App.LoadedCharacter.CharacterStats.DexterityModifier +
         GetProficiencyModifier(AcrobaticsExpertiseChecked, AcrobaticsProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region SleightOfHand

    public bool SleightOfHandExpertiseChecked
    {
        get => _sleightOfHandExpertiseChecked;
        set
        {
            _sleightOfHandExpertiseChecked = value;
            if (!value && SleightOfHandProficiencyChecked) SleightOfHandProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(SleightOfHandProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _sleightOfHandExpertiseChecked;

    public bool SleightOfHandProficiencyChecked
    {
        get => _sleightOfHandProficiencyChecked;
        set
        {
            _sleightOfHandProficiencyChecked = value;
            if (value) SleightOfHandExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _sleightOfHandProficiencyChecked;

    public string SleightOfHandModifierText =>
        (App.LoadedCharacter.CharacterStats.DexterityModifier +
         GetProficiencyModifier(SleightOfHandExpertiseChecked, SleightOfHandProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Stealth

    public bool StealthExpertiseChecked
    {
        get => _stealthExpertiseChecked;
        set
        {
            _stealthExpertiseChecked = value;
            if (!value && StealthProficiencyChecked) StealthProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(StealthProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _stealthExpertiseChecked;

    public bool StealthProficiencyChecked
    {
        get => _stealthProficiencyChecked;
        set
        {
            _stealthProficiencyChecked = value;
            if (value) StealthExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _stealthProficiencyChecked;

    public string StealthModifierText =>
        (App.LoadedCharacter.CharacterStats.DexterityModifier +
         GetProficiencyModifier(StealthExpertiseChecked, StealthProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Arcana

    public bool ArcanaExpertiseChecked
    {
        get => _arcanaExpertiseChecked;
        set
        {
            _arcanaExpertiseChecked = value;
            if (!value && ArcanaProficiencyChecked) ArcanaProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(ArcanaProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _arcanaExpertiseChecked;

    public bool ArcanaProficiencyChecked
    {
        get => _arcanaProficiencyChecked;
        set
        {
            _arcanaProficiencyChecked = value;
            if (value) ArcanaExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _arcanaProficiencyChecked;

    public string ArcanaModifierText =>
        (App.LoadedCharacter.CharacterStats.IntelligenceModifier +
         GetProficiencyModifier(ArcanaExpertiseChecked, ArcanaProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region History

    public bool HistoryExpertiseChecked
    {
        get => _historyExpertiseChecked;
        set
        {
            _historyExpertiseChecked = value;
            if (!value && HistoryProficiencyChecked) HistoryProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(HistoryProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _historyExpertiseChecked;

    public bool HistoryProficiencyChecked
    {
        get => _historyProficiencyChecked;
        set
        {
            _historyProficiencyChecked = value;
            if (value) HistoryExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _historyProficiencyChecked;

    public string HistoryModifierText =>
        (App.LoadedCharacter.CharacterStats.IntelligenceModifier +
         GetProficiencyModifier(HistoryExpertiseChecked, HistoryProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Investigation

    public bool InvestigationExpertiseChecked
    {
        get => _investigationExpertiseChecked;
        set
        {
            _investigationExpertiseChecked = value;
            if (!value && InvestigationProficiencyChecked) InvestigationProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(InvestigationProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _investigationExpertiseChecked;

    public bool InvestigationProficiencyChecked
    {
        get => _investigationProficiencyChecked;
        set
        {
            _investigationProficiencyChecked = value;
            if (value) InvestigationExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _investigationProficiencyChecked;

    public string InvestigationModifierText =>
        (App.LoadedCharacter.CharacterStats.IntelligenceModifier +
         GetProficiencyModifier(InvestigationExpertiseChecked, InvestigationProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Nature

    public bool NatureExpertiseChecked
    {
        get => _natureExpertiseChecked;
        set
        {
            _natureExpertiseChecked = value;
            if (!value && NatureProficiencyChecked) NatureProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(NatureProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _natureExpertiseChecked;

    public bool NatureProficiencyChecked
    {
        get => _natureProficiencyChecked;
        set
        {
            _natureProficiencyChecked = value;
            if (value) NatureExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _natureProficiencyChecked;

    public string NatureModifierText =>
        (App.LoadedCharacter.CharacterStats.IntelligenceModifier +
         GetProficiencyModifier(NatureExpertiseChecked, NatureProficiencyChecked))
        .ToString("+0;-#");

    #endregion
    
    #region Religion
    public bool ReligionExpertiseChecked
    {
        get => _religionExpertiseChecked;
        set
        {
            _religionExpertiseChecked = value;
            if (!value && ReligionProficiencyChecked) ReligionProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(ReligionProficiencyChecked));
            UpdateSkills();
        }
    }
    private bool _religionExpertiseChecked = false;

    public bool ReligionProficiencyChecked
    {
        get => _religionProficiencyChecked;
        set
        {
            _religionProficiencyChecked = value;
            if (value) ReligionExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }
    private bool _religionProficiencyChecked = false;

    public string ReligionModifierText => 
        (App.LoadedCharacter.CharacterStats.IntelligenceModifier + 
         GetProficiencyModifier(ReligionExpertiseChecked, ReligionProficiencyChecked))
        .ToString("+0;-#");
    #endregion

    #region AnimalHandling

    public bool AnimalHandlingExpertiseChecked
    {
        get => _animalHandlingExpertiseChecked;
        set
        {
            _animalHandlingExpertiseChecked = value;
            if (!value && AnimalHandlingProficiencyChecked) AnimalHandlingProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(AnimalHandlingProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _animalHandlingExpertiseChecked;

    public bool AnimalHandlingProficiencyChecked
    {
        get => _animalHandlingProficiencyChecked;
        set
        {
            _animalHandlingProficiencyChecked = value;
            if (value) AnimalHandlingExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _animalHandlingProficiencyChecked;

    public string AnimalHandlingModifierText =>
        (App.LoadedCharacter.CharacterStats.WisdomModifier +
         GetProficiencyModifier(AnimalHandlingExpertiseChecked, AnimalHandlingProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Insight

    public bool InsightExpertiseChecked
    {
        get => _insightExpertiseChecked;
        set
        {
            _insightExpertiseChecked = value;
            if (!value && InsightProficiencyChecked) InsightProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(InsightProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _insightExpertiseChecked;

    public bool InsightProficiencyChecked
    {
        get => _insightProficiencyChecked;
        set
        {
            _insightProficiencyChecked = value;
            if (value) InsightExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _insightProficiencyChecked;

    public string InsightModifierText =>
        (App.LoadedCharacter.CharacterStats.WisdomModifier +
         GetProficiencyModifier(InsightExpertiseChecked, InsightProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Medicine

    public bool MedicineExpertiseChecked
    {
        get => _medicineExpertiseChecked;
        set
        {
            _medicineExpertiseChecked = value;
            if (!value && MedicineProficiencyChecked) MedicineProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(MedicineProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _medicineExpertiseChecked;

    public bool MedicineProficiencyChecked
    {
        get => _medicineProficiencyChecked;
        set
        {
            _medicineProficiencyChecked = value;
            if (value) MedicineExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _medicineProficiencyChecked;

    public string MedicineModifierText =>
        (App.LoadedCharacter.CharacterStats.WisdomModifier +
         GetProficiencyModifier(MedicineExpertiseChecked, MedicineProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Perception

    public bool PerceptionExpertiseChecked
    {
        get => _perceptionExpertiseChecked;
        set
        {
            _perceptionExpertiseChecked = value;
            if (!value && PerceptionProficiencyChecked) PerceptionProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(PerceptionProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _perceptionExpertiseChecked;

    public bool PerceptionProficiencyChecked
    {
        get => _perceptionProficiencyChecked;
        set
        {
            _perceptionProficiencyChecked = value;
            if (value) PerceptionExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _perceptionProficiencyChecked;

    public string PerceptionModifierText =>
        (App.LoadedCharacter.CharacterStats.WisdomModifier +
         GetProficiencyModifier(PerceptionExpertiseChecked, PerceptionProficiencyChecked))
        .ToString("+0;-#");

    #endregion
    
    #region Survival
    public bool SurvivalExpertiseChecked
    {
        get => _survivalExpertiseChecked;
        set
        {
            _survivalExpertiseChecked = value;
            if (!value && SurvivalProficiencyChecked) SurvivalProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(SurvivalProficiencyChecked));
            UpdateSkills();
        }
    }
    private bool _survivalExpertiseChecked = false;

    public bool SurvivalProficiencyChecked
    {
        get => _survivalProficiencyChecked;
        set
        {
            _survivalProficiencyChecked = value;
            if (value) SurvivalExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }
    private bool _survivalProficiencyChecked = false;

    public string SurvivalModifierText => 
        (App.LoadedCharacter.CharacterStats.WisdomModifier + 
         GetProficiencyModifier(SurvivalExpertiseChecked, SurvivalProficiencyChecked))
        .ToString("+0;-#");
    #endregion

    #region Deception

    public bool DeceptionExpertiseChecked
    {
        get => _deceptionExpertiseChecked;
        set
        {
            _deceptionExpertiseChecked = value;
            if (!value && DeceptionProficiencyChecked) DeceptionProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(DeceptionProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _deceptionExpertiseChecked;

    public bool DeceptionProficiencyChecked
    {
        get => _deceptionProficiencyChecked;
        set
        {
            _deceptionProficiencyChecked = value;
            if (value) DeceptionExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _deceptionProficiencyChecked;

    public string DeceptionModifierText =>
        (App.LoadedCharacter.CharacterStats.CharismaModifier +
         GetProficiencyModifier(DeceptionExpertiseChecked, DeceptionProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Intimidation

    public bool IntimidationExpertiseChecked
    {
        get => _intimidationExpertiseChecked;
        set
        {
            _intimidationExpertiseChecked = value;
            if (!value && IntimidationProficiencyChecked) IntimidationProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IntimidationProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _intimidationExpertiseChecked;

    public bool IntimidationProficiencyChecked
    {
        get => _intimidationProficiencyChecked;
        set
        {
            _intimidationProficiencyChecked = value;
            if (value) IntimidationExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _intimidationProficiencyChecked;

    public string IntimidationModifierText =>
        (App.LoadedCharacter.CharacterStats.CharismaModifier +
         GetProficiencyModifier(IntimidationExpertiseChecked, IntimidationProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Performance

    public bool PerformanceExpertiseChecked
    {
        get => _performanceExpertiseChecked;
        set
        {
            _performanceExpertiseChecked = value;
            if (!value && PerformanceProficiencyChecked) PerformanceProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(PerformanceProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _performanceExpertiseChecked;

    public bool PerformanceProficiencyChecked
    {
        get => _performanceProficiencyChecked;
        set
        {
            _performanceProficiencyChecked = value;
            if (value) PerformanceExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _performanceProficiencyChecked;

    public string PerformanceModifierText =>
        (App.LoadedCharacter.CharacterStats.CharismaModifier +
         GetProficiencyModifier(PerformanceExpertiseChecked, PerformanceProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    #region Persuasion

    public bool PersuasionExpertiseChecked
    {
        get => _persuasionExpertiseChecked;
        set
        {
            _persuasionExpertiseChecked = value;
            if (!value && PersuasionProficiencyChecked) PersuasionProficiencyChecked = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(PersuasionProficiencyChecked));
            UpdateSkills();
        }
    }

    private bool _persuasionExpertiseChecked;

    public bool PersuasionProficiencyChecked
    {
        get => _persuasionProficiencyChecked;
        set
        {
            _persuasionProficiencyChecked = value;
            if (value) PersuasionExpertiseChecked = value;
            NotifyPropertyChanged();
            UpdateSkills();
        }
    }

    private bool _persuasionProficiencyChecked;

    public string PersuasionModifierText =>
        (App.LoadedCharacter.CharacterStats.CharismaModifier +
         GetProficiencyModifier(PersuasionExpertiseChecked, PersuasionProficiencyChecked))
        .ToString("+0;-#");

    #endregion

    private void UpdateSkills()
    {
        NotifyPropertyChanged(nameof(AthleticsModifierText));
        NotifyPropertyChanged(nameof(AcrobaticsModifierText));
        NotifyPropertyChanged(nameof(SleightOfHandModifierText));
        NotifyPropertyChanged(nameof(StealthModifierText));
        NotifyPropertyChanged(nameof(ArcanaModifierText));
        NotifyPropertyChanged(nameof(HistoryModifierText));
        NotifyPropertyChanged(nameof(InvestigationModifierText));
        NotifyPropertyChanged(nameof(NatureModifierText));
        NotifyPropertyChanged(nameof(ReligionModifierText));
        NotifyPropertyChanged(nameof(AnimalHandlingModifierText));
        NotifyPropertyChanged(nameof(InsightModifierText));
        NotifyPropertyChanged(nameof(MedicineModifierText));
        NotifyPropertyChanged(nameof(PerceptionModifierText));
        NotifyPropertyChanged(nameof(SurvivalModifierText));
        NotifyPropertyChanged(nameof(DeceptionModifierText));
        NotifyPropertyChanged(nameof(IntimidationModifierText));
        NotifyPropertyChanged(nameof(PerformanceModifierText));
        NotifyPropertyChanged(nameof(PersuasionModifierText));
    }

    private static int GetProficiencyModifier(bool expertise, bool proficiency)
    {
        return ((expertise ? 1 : 0) + (proficiency ? 1 : 0)) * GetProficiencyBonus();
    }

    private static int GetProficiencyBonus()
    {
        return App.LoadedCharacter.Level / 4 + 2;
    }

    #endregion
}