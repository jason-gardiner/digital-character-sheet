using System;

namespace DigitalCharacterSheet.character;

public class CharacterStatistics
{
    public struct StatsArray
    {
        public StatsArray(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public int Strength
        {
            get => _strength;
            set => _strength = VerifyStat(value);
        }

        public int Dexterity
        {
            get => _dexterity;
            set => _dexterity = VerifyStat(value);
        }

        public int Constitution
        {
            get => _constitution;
            set => _constitution = VerifyStat(value);
        }

        public int Intelligence
        {
            get => _intelligence;
            set => _intelligence = VerifyStat(value);
        }

        public int Wisdom
        {
            get => _wisdom;
            set => _wisdom = VerifyStat(value);
        }
        
        public int Charisma
        {
            get => _charisma;
            set => _charisma = VerifyStat(value);
        }

        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _intelligence;
        private int _wisdom;
        private int _charisma;


        private static int VerifyStat(int stat)
        {
            return stat switch
            {
                >= 30 => 30,
                <= 0 => 1,
                _ => stat
            };
        }
    };

    private StatsArray _statsArray;

    public CharacterStatistics(StatsArray statsArray)
    {
        _statsArray = statsArray;
    }

    public int StrengthModifier => (int)MathF.Floor((_statsArray.Strength - 10) / 2f);
    public int DexterityModifier => (int)MathF.Floor((_statsArray.Dexterity - 10) / 2f);
    public int ConstitutionModifier => (int)MathF.Floor((_statsArray.Constitution - 10) / 2f);
    public int IntelligenceModifier => (int)MathF.Floor((_statsArray.Intelligence - 10) / 2f);
    public int WisdomModifier => (int)MathF.Floor((_statsArray.Wisdom - 10) / 2f);
    public int CharismaModifier => (int)MathF.Floor((_statsArray.Charisma- 10) / 2f);
}