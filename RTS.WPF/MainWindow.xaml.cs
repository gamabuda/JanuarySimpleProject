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
        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();

            MyImage.Content = Resources["blank"];

            this.DataContext = unit;
        }

        public object PropertyChanged { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit.Experience = unit.Experience + 1000;
            unit.TotalExp = unit.TotalExp + unit.Experience;
            unit.LevelUp();

            unit.Strength++;
            unit.Inteligence++;
            unit.Vitality++;
            unit.Dexterity++;
            unit.StartsPoints++;
            this.DataContext = unit;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (unit.Strength == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Strength--;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Strength++;
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Dexterity++;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (unit.Dexterity == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Dexterity--;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Inteligence++;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (unit.Inteligence == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Inteligence--;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Vitality++;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (unit.Vitality == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Vitality--;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();

            MyImage.Content = Resources["Warrior"];

            this.DataContext = unit;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();

            MyImage.Content = Resources["Wizzard"];

            this.DataContext = unit;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();

            MyImage.Content = Resources["Rogue"];

            this.DataContext = unit;
        }
    }
}
