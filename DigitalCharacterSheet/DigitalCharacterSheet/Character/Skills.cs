using Avalonia.Controls;
using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

/*
namespace DigitalCharacterSheet.Character
{
   public class Skills
   {

      //All functions need data binding to read and write
      public int calculateProficiencyBonus() {

         //Don't know how to do Data Binding. Found some stuff that might help someone get started
         var source = new Subject<string>();
         var levelBox = new TextBlock();

         var subject = levelBox.Bind(TextBlock.TextProperty, source);



         int proficiency;
         int levelNum;

         //Level.Text is the string in the Level text box
         if (int.TryParse(Level.Text, out levelNum))
         {
            if (levelNum <= 4) { proficiency = 2; }
            else if (levelNum > 4 && levelNum <= 8) { proficiency = 3; }
            else if (levelNum > 8 && levelNum <= 12) { proficiency = 4; }
            else if (levelNum > 12 && levelNum <= 16) { proficiency = 5; }
            else if (levelNum > 16 && levelNum <= 20) { proficiency = 6; }
            else { proficiency = 0; }
         }
         else
         {
            proficiency = 2;
         }

         subject.Dispose();
         return proficiency;
      }

      public int acrobaticsProfBonus(object sender, KeyEventArgs e) {
         
         int prof = calculateProficiencyBonus();

         if (!AcrobaticsProficiency.IsChecked)
         {
            prof = 0;
         }
         if (AcrobaticsExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + DexMod;

         return bonus;
      }

      public int animalHandlingProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!AnimalHandlingProficiency.IsChecked)
         {
            prof = 0;
         }
         if (AnimalHandlingExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + WisMod;

         return bonus;
      }

      public int arcanaProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!ArcanaProficiency.IsChecked)
         {
            prof = 0;
         }
         if (ArcanaExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + IntMod;

         return bonus;
      }

      public int athleticsProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!AthleticsProficiency.IsChecked)
         {
            prof = 0;
         }
         if (AthleticsExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + StrMod;

         return bonus;
      }

      public int deceptionProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!DeceptionProficiency.IsChecked)
         {
            prof = 0;
         }
         if (DeceptionExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + ChaMod;

         return bonus;
      }

      public int historyProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!HistoryProficiency.IsChecked)
         {
            prof = 0;
         }
         if (HistoryExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + IntMod;

         return bonus;
      }

      public int insightProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!InsightProficiency.IsChecked)
         {
            prof = 0;
         }
         if (InsightExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + WisMod;

         return bonus;
      }

      public int intimidationProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!IntimidationProficiency.IsChecked)
         {
            prof = 0;
         }
         if (IntimidationExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + ChaMod;

         return bonus;
      }

      public int investigationProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!InvestigationProficiency.IsChecked)
         {
            prof = 0;
         }
         if (InvestigationExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + IntMod;

         return bonus;
      }

      public int medicineProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!MedicineProficiency.IsChecked)
         {
            prof = 0;
         }
         if (MedicineExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + WisMod;

         return bonus;
      }

      public int natureProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!NatureProficiency.IsChecked)
         {
            prof = 0;
         }
         if (NatureExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + IntMod;

         return bonus;
      }

      public int perceptionProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!PerceptionProficiency.IsChecked)
         {
            prof = 0;
         }
         if (PerceptionExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + WisMod;

         return bonus;
      }

      public int performanceProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!PerformanceProficiency.IsChecked)
         {
            prof = 0;
         }
         if (PerformanceExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + ChaMod;

         return bonus;
      }

      public int persuasionProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!PersuasionProficiency.IsChecked)
         {
            prof = 0;
         }
         if (PersuasionExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + ChaMod;

         return bonus;
      }

      public int religionProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!ReligionProficiency.IsChecked)
         {
            prof = 0;
         }
         if (ReligionExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + IntMod;

         return bonus;
      }

      public int sleightOfHandProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!SleightOfHandProficiency.IsChecked)
         {
            prof = 0;
         }
         if (SleightofHandExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + DexMod;

         return bonus;
      }

      public int stealthProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!StealthProficiency.IsChecked)
         {
            prof = 0;
         }
         if (StealthExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + DexMod;

         return bonus;
      }

      public int survivalProfBonus()
      {

         int prof = calculateProficiencyBonus();

         if (!SurvivalProficiency.IsChecked)
         {
            prof = 0;
         }
         if (SurvivalExpertise.IsChecked)
         {
            prof *= 2;
         }

         int bonus = prof + WisMod;

         return bonus;
      }

   }
}
*/