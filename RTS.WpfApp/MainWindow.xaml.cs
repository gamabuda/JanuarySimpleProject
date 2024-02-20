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

namespace RTS.WpfApp
{
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            Unit unit;
        Image CharacterImage;

        public MainWindow()
            {
                InitializeComponent();
            unit = new Unit();
            
           
            unit = new Warrior();
            this.DataContext = unit;
            }
        public object PropertyChanged { get; private set; }
       


        private void Button_Click_LevelUp(object sender, RoutedEventArgs e)
            {
              
                unit.Experience = unit.Experience + 1000;
                unit.LevelUp();
                    unit.Strength++;
                    unit.Dexterity++;
                    unit.Intelligence++;
                    unit.Vitality++;
                this.DataContext = unit;
            }

      
        private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                unit= new Warrior();
            
            this.DataContext = unit;
        }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                unit=(new Rogue());
           
            this.DataContext = unit;
        }

            private void Button_Click_3(object sender, RoutedEventArgs e)
            {
                unit=(new Wizard());
            this.DataContext = unit;
        }



        private void StrenghtUp(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DexterityUP(object sender, RoutedEventArgs e)
        {

        }


        private void StrenghtDown(object sender, RoutedEventArgs e)
        {

        }

        private void VitalityDown(object sender, RoutedEventArgs e)
        {

        }

        private void IntelligenceDown(object sender, RoutedEventArgs e)
        {

        }

        private void DexterityDown(object sender, RoutedEventArgs e)
        {

        }

        private void IntelligenceUp(object sender, RoutedEventArgs e)
        {

        }

        private void IntellligenceUp(object sender, RoutedEventArgs e)
        {

        }

        private void VitalityUp(object sender, RoutedEventArgs e)
        {

        }
    }
    }