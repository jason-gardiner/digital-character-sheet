using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCharacterSheet.character;

namespace DigitalCharacterSheet.Character;
public class Character
{
   public Character()
   {
      Name = "";
      Race = "";
   }
   Character(string name = "", string race = "", Tuple<string, int>[] charClass = null)
   {
      Name = name;
      Race = race;
      CharacterClass = charClass;
   }
   
#region MoveToDifferentClassLater
   public string Name { set; get; }

   public int Level { private set; get; }
   public void SetLevel()
   {
      Level = 0;
      for (int i = 0; i < _characterClass.Length; i++)
      {
         Level += _characterClass[i].Item2;
      }
   }

   public string Race { set; get; }

   //The character class is an array of Tuples that are <"Character Class Name", Level in Class>
   private Tuple<string, int>[] _characterClass;

   public Tuple<string, int>[] CharacterClass
   {
      set
      {
         _characterClass = value;
         SetLevel();
      }
      get => _characterClass;
   }
   
#endregion
   
   public CharacterStatistics CharacterStats = new();
}