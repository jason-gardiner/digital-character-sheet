using System;

namespace DigitalCharacterSheet.character;

public class CharacterStatistics
{
    public struct BackingStatistics
    {
        public BackingStatistics(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        internal int Strength = 10;
        internal int Dexterity = 10;
        internal int Constitution = 10;
        internal int Intelligence = 10;
        internal int Wisdom = 10;
        internal int Charisma = 10;


        public static int VerifyStat(int stat)
        {
            return stat switch
            {
                >= 30 => 30,
                <= 0 => 1,
                _ => stat
            };
        }
    };
    
    public int Strength
    {
        get => _statsArray.Strength;
        set => _statsArray.Strength = BackingStatistics.VerifyStat(value);
    }

    public int Dexterity
    {
        get => _statsArray.Dexterity;
        set => _statsArray.Dexterity = BackingStatistics.VerifyStat(value);
    }

    public int Constitution
    {
        get => _statsArray.Constitution;
        set => _statsArray.Constitution = BackingStatistics.VerifyStat(value);
    }

    public int Intelligence
    {
        get => _statsArray.Intelligence;
        set => _statsArray.Intelligence = BackingStatistics.VerifyStat(value);
    }

    public int Wisdom
    {
        get => _statsArray.Wisdom;
        set => _statsArray.Wisdom = BackingStatistics.VerifyStat(value);
    }
        
    public int Charisma
    {
        get => _statsArray.Charisma;
        set => _statsArray.Charisma = BackingStatistics.VerifyStat(value);
    }

    private BackingStatistics _statsArray;

    public CharacterStatistics(BackingStatistics statsArray)
    {
        _statsArray = statsArray;
    }

    public CharacterStatistics()
    {
        _statsArray = new BackingStatistics(10, 10, 10, 10, 10, 10);
    }

    public int StrengthModifier => (int)MathF.Floor((Strength - 10) / 2f);
    public int DexterityModifier => (int)MathF.Floor((Dexterity - 10) / 2f);
    public int ConstitutionModifier => (int)MathF.Floor((Constitution - 10) / 2f);
    public int IntelligenceModifier => (int)MathF.Floor((Intelligence - 10) / 2f);
    public int WisdomModifier => (int)MathF.Floor((Wisdom - 10) / 2f);
    public int CharismaModifier => (int)MathF.Floor((Charisma- 10) / 2f);
}