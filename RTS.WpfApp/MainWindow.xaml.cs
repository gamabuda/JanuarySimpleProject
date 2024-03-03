using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.WpfApp

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Unit unit;
        //Image CharacterImage;

        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();
            MyImage.Content = Resources["blank"];

            this.DataContext = unit;
        }
        public object PropertyChanged { get; private set; }





        private void Button_Click_LevelUp(object sender, RoutedEventArgs e)
        {

            unit.Experience = unit.Experience + 1000;
            unit.TotalExp = unit.TotalExp + unit.Experience;
            unit.LevelUp();

            unit.Strength++;
            unit.Dexterity++;
            unit.Intelligence++;
            unit.Vitality++;
            unit.StartsPoints++;
            this.DataContext = unit;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //unit = new Warrior();

            //this.DataContext = unit;
            unit = new Warrior();

            UnitClass.Text = "Warrior";
            MyImage.Content = Resources["Warrior"];

            this.DataContext = unit;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();

            UnitClass.Text = "Rogue";
            MyImage.Content = Resources["Rogue"];

            this.DataContext = unit;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();

            UnitClass.Text = "Wizzard";
            MyImage.Content = Resources["Wizard"];

            this.DataContext = unit;
        }



        private void StrenghtUp(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Strength++;

            }
        }


        

        private void StrenghtDown(object sender, RoutedEventArgs e)
        {
            if (unit.Strength == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Strength--;
            }
        }

        private void DexterityDown(object sender, RoutedEventArgs e)
        {
            if (unit.Dexterity == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Dexterity--;
            }
        }

        private void IntelligenceDown(object sender, RoutedEventArgs e)
        {
            if (unit.Intelligence == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Intelligence--;
            }
        }

        private void VitalityDown(object sender, RoutedEventArgs e)
        {
            if (unit.Vitality == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Vitality--;
            }
        }

        private void VitalityUp(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Vitality++;
            }
        }

        private void IntellligenceUp(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Intelligence++;
            }
        }

        private void DexterityUP(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Dexterity++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit = new Catapulta();

            UnitClass.Text = "Catapulta";
            MyImage.Content = Resources["Catapulta"];

            this.DataContext = unit;
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            unit = new Peasent();

            UnitClass.Text = "Peasent";
            MyImage.Content = Resources["Peasent"];

            this.DataContext = unit;
        }
    }
}