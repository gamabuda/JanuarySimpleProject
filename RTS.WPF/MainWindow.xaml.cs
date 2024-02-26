using Microsoft.Win32;
using RTS.Core;
using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.WPF
{

    public partial class MainWindow : Window
    {
        Unit unit;

        int CountOfPointsS = 0;
        int CountOfPointsD = 0;
        int CountOfPointsV = 0;
        int CountOfPointsI = 0;

        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();

            MyImage.Content = Resources["blank"];

            this.DataContext = unit;
        }

        public object PropertyChanged { get; private set; }

        private void GetExp(object sender, RoutedEventArgs e)
        {
            unit.Experience = unit.Experience + 1000;
            unit.TotalExp = unit.TotalExp + unit.Experience;
            unit.LevelUp();

            unit.Strength++;
            unit.Inteligence++;
            unit.Vitality++;
            unit.Dexterity++;
            unit.StartsPoints++;

            if (unit is Wizzard)
            {
                unit.HP = (int)(unit.Vitality / 1.5 + unit.Strength / 0.5);
                unit.Mana = (int)(unit.Inteligence / 1.5);
            }
            else if (unit is Warrior)
            {
                unit.HP = (int)(unit.Vitality / 2 + unit.Strength);
                unit.Mana = (int)(unit.Inteligence);
            }
            else if (unit is Rogue)
            {
                unit.HP = (int)(unit.Vitality / 1.5 + unit.Strength / 0.5);
                unit.Mana = (int)(unit.Inteligence / 1.2);
            }
            else if (unit is Peasant)
            {
                unit.HP = (int)(unit.Vitality / 1 + unit.Strength);
                unit.Mana = (int)(unit.Inteligence);
            } 
            else if (unit is Catapult)
            {
                unit.HP = (int)(unit.Vitality / 1 + unit.Strength);
                unit.Mana = (int)(unit.Inteligence / 0.4);
            }   
            else
                throw new Exception("Unit is doesnot exist");
            this.DataContext = unit;
        }

        private void MinusStrength(object sender, RoutedEventArgs e)
        {
            if (CountOfPointsS == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Strength--;
                CountOfPointsS--;
            }
        }

        private void PlusStrength(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Strength++;
                CountOfPointsS++;
            }
        }


        private void PlusDexterity(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Dexterity++;
                CountOfPointsD++;
            }
        }

        private void MinusDexterity(object sender, RoutedEventArgs e)
        {
            if (CountOfPointsD == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Dexterity--;
                CountOfPointsD--;
            }
        }

        private void PlusInteligence(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Inteligence++;
                CountOfPointsI++;
            }
        }

        private void MinusInteligence(object sender, RoutedEventArgs e)
        {
            if (CountOfPointsI == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Inteligence--;
                CountOfPointsI--;
            }
        }

        private void PlusVitality(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Vitality++;
                CountOfPointsV++;
            }
        }

        private void MinusVitality(object sender, RoutedEventArgs e)
        {
            if (CountOfPointsV == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Vitality--;
                CountOfPointsV--;
            }
        }

        private void CreateWarrior(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();

            UnitClass.Text = "Warrior";
            MyImage.Content = Resources["Warrior"];

            this.DataContext = unit;
        }

        private void CreateWizzard(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();

            UnitClass.Text = "Wizzard";
            MyImage.Content = Resources["Wizzard"];

            this.DataContext = unit;
        }

        private void CreateRogue(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();

            UnitClass.Text = "Rogue";
            MyImage.Content = Resources["Rogue"];

            this.DataContext = unit;
        }

        private void CreatePeasant(object sender, RoutedEventArgs e)
        {
            unit = new Peasant();

            UnitClass.Text = "Peasant";
            MyImage.Content = Resources["Peasant"];

            this.DataContext = unit;
        }

        private void CreateCatapult(object sender, RoutedEventArgs e)
        {
            unit = new Catapult();

            UnitClass.Text = "Catapult";
            MyImage.Content = Resources["Catapult"];

            this.DataContext = unit;
        }
    }
}
