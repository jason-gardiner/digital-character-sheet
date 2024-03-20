using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCharacterSheet.character
{
   public class character
   {
      private String name;
      private int level;
      private String race;
      //The character class is an array of Tuples that are <"Character Class Name", Level in Class>
      private Tuple<String, int>[] characterClass = null;

      character(string name = "", string race = "", Tuple<String, int>[] charClass = null)
      {
         setName(name);
         setRace(race);
         setCharacterClass(charClass);
      }

      public void setName(string name)
      {
         this.name = name;
      }

      public void setLevel()
      {
         this.level = 0;
         for (int i = 0; i < characterClass.Length; i++)
         {
            level += characterClass[i].Item2;
         }
      }

      public void setRace(string race)
      {
         this.race = race;
      }

      public void setCharacterClass(Tuple<String, int>[] charClass)
      {
         this.characterClass = charClass;
         setLevel();
      }

      public String getName()
      {
         return this.name;
      }

      public int getLevel()
      {
         return this.level;
      }

      public String getRace()
      {
         return this.race;
      }

      public Tuple<String, int>[] getCharacterClass()
      {
         return this.characterClass;
      }
   }
}
