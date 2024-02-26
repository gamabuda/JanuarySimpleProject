using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTS.Core;
using RTS.Core.Units;
using RTS.Core.Buildings;

namespace RTS.WPF
{
    public partial class MainWindow : Window
    {
        Unit unit;
        int minStr;
        int minDex;
        int minInt;
        int minVit;
        public MainWindow()
        {
            InitializeComponent();
            StrPlus.IsEnabled = false;
            StrMinus.IsEnabled = false;
            DexPlus.IsEnabled = false;
            DexMinus.IsEnabled = false;
            IntPlus.IsEnabled = false;
            IntMinus.IsEnabled = false;
            VitPlus.IsEnabled = false;
            VitMinus.IsEnabled = false;
            GetExp.IsEnabled = false;
            ConfirmSkillChange.IsEnabled = false;
        }

        private void StatsUpdate()
        {
            if (unit is Warrior)
                CurrentClass.Text = "WARRIOR";
            else if (unit is Rogue)
                CurrentClass.Text = "ROGUE";
            else if (unit is Wizard)
                CurrentClass.Text = "WIZARD";

            CurrentLevel.Text = $"{unit.Level}";
            CurrentExp.Text = $"{unit.Experience}";
            NewLevelExp.Text = $"{unit.LevelUpMinExperience}";

            if (unit.Level == 50)
                NewLevelExp.Text = "MAX LEVEL";

            Health.Text = $"{unit.Health}";
            MaxHealth.Text = $"{unit.MaxHealth}";

            Mana.Text = $"{unit.Mana}";
            MaxMana.Text = $"{unit.MaxMana}";

            StrCurrentStats.Text = $"{unit.Strength}";
            StrMaxStats.Text = $"{unit.MaxStrength}";

            DexCurrentStats.Text = $"{unit.Dexterity}";
            DexMaxStats.Text = $"{unit.MaxDexterity}";

            IntCurrentStats.Text = $"{unit.Intelligence}";
            IntMaxStats.Text = $"{unit.MaxIntelligence}";

            VitCurrentStats.Text = $"{unit.Vitality}";
            VitMaxStats.Text = $"{unit.MaxVitality}";

            Points.Text = $"{unit.Points}";
        }

        private void ChooseClassWarrior_Click(object sender, RoutedEventArgs e)
        {
            unit = Barrack.CreateUnit("warrior");
            StatsUpdate();
            UnitIMG.Content = Resources["Warrior"];

            minStr = unit.Strength;
            minDex = unit.Dexterity;
            minInt = unit.Intelligence;
            minVit = unit.Vitality;

            StrPlus.IsEnabled = true;
            StrMinus.IsEnabled = true;
            DexPlus.IsEnabled = true;
            DexMinus.IsEnabled = true;
            IntPlus.IsEnabled = true;
            IntMinus.IsEnabled = true;
            VitPlus.IsEnabled = true;
            VitMinus.IsEnabled = true;
            GetExp.IsEnabled = true;
        }

        private void ChooseClassRogue_Click(object sender, RoutedEventArgs e)
        {
            unit = Barrack.CreateUnit("rogue");
            StatsUpdate();
            UnitIMG.Content = Resources["Rogue"];

            minStr = unit.Strength;
            minDex = unit.Dexterity;
            minInt = unit.Intelligence;
            minVit = unit.Vitality;

            StrPlus.IsEnabled = true;
            StrMinus.IsEnabled = true;
            DexPlus.IsEnabled = true;
            DexMinus.IsEnabled = true;
            IntPlus.IsEnabled = true;
            IntMinus.IsEnabled = true;
            VitPlus.IsEnabled = true;
            VitMinus.IsEnabled = true;
            GetExp.IsEnabled = true;
        }

        private void ChooseClassWizard_Click(object sender, RoutedEventArgs e)
        {
            unit = Barrack.CreateUnit("wizard");
            StatsUpdate();
            UnitIMG.Content = Resources["Wizard"];

            minStr = unit.Strength;
            minDex = unit.Dexterity;
            minInt = unit.Intelligence;
            minVit = unit.Vitality;

            StrPlus.IsEnabled = true;
            StrMinus.IsEnabled = true;
            DexPlus.IsEnabled = true;
            DexMinus.IsEnabled = true;
            IntPlus.IsEnabled = true;
            IntMinus.IsEnabled = true;
            VitPlus.IsEnabled = true;
            VitMinus.IsEnabled = true;
            GetExp.IsEnabled = true;
        }

        private void GetExp_Click(object sender, RoutedEventArgs e)
        {
            unit.Experience += 10000;
            unit.LevelUp();
            StatsUpdate();
        }

        private void ConfirmSkillChange_Click(object sender, RoutedEventArgs e)
        {
            minStr = unit.Strength;
            minDex = unit.Dexterity;
            minInt = unit.Intelligence;
            minVit = unit.Vitality;

            ConfirmSkillChange.IsEnabled = false;
        }

        private void StrPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Strength == unit.MaxStrength)
                return;

            if (unit.Points == 0)
                return;

            unit.Strength++;
            unit.Points--;

            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void StrMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Strength == minStr)
                return;

            unit.Strength--;
            unit.Points++;
            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void DexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Dexterity == unit.MaxDexterity)
                return;

            if (unit.Points == 0)
                return;

            unit.Dexterity++;
            unit.Points--;

            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void DexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Dexterity == minDex)
                return;

            unit.Dexterity--;
            unit.Points++;
            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void IntPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Intelligence == unit.MaxIntelligence)
                return;

            if (unit.Points == 0)
                return;

            unit.Intelligence++;
            unit.Points--;

            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void IntMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Intelligence == minInt)
                return;

            unit.Intelligence--;
            unit.Points++;
            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void VitPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Vitality == unit.MaxVitality)
                return;

            if (unit.Points == 0)
                return;

            unit.Vitality++;
            unit.Points--;

            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }

        private void VitMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Vitality == minVit)
                return;

            unit.Vitality--;
            unit.Points++;
            ConfirmSkillChange.IsEnabled = true;
            StatsUpdate();
        }
    }
}