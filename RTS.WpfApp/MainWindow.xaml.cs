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
            public Core.Unit unit;

            public MainWindow()
            {
                InitializeComponent();
                SetUnit(new Warrior());
            }

            private void SetUnit(Core.Unit newUnit)
            {
                unit = newUnit;
                this.DataContext = unit;
            }

            private void Button_Click_LevelUp(object sender, RoutedEventArgs e)
            {
                if (unit != null)
                {
                unit.Experience = unit.Experience + 1000;
                unit.LevelUp();
                    unit.Strength++;
                    unit.Dexterity++;
                    unit.Intelligence++;
                    unit.Vitality++;
                }
            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                SetUnit(new Warrior());
            }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                SetUnit(new Rogue());
            }

            private void Button_Click_3(object sender, RoutedEventArgs e)
            {
                SetUnit(new Wizard());
            }
        }
    }