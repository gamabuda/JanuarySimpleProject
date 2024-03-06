using RTS.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Unit unit;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();

            image.Content = Resources["Warrior"];

            DataContext = unit;
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();

            image.Content = Resources["Rogue"];

            DataContext = unit;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();

            image.Content = Resources["Wizard"];

            DataContext = unit;
        }

        private void IncreaseVitality_Click(object sender, RoutedEventArgs e)
        {
            unit.Vitality++;
            unit.Points--;
            DataContext = unit;
        }

        private void DecreaseVitality_Click(object sender, RoutedEventArgs e)
        {
            unit.Vitality--;
            unit.Points++;
            DataContext = unit;
        }

        private void IncreaseIntelligence_Click(object sender, RoutedEventArgs e)
        {
            unit.Intelligence++;
            unit.Points--;
            DataContext = unit;
        }

        private void DecreaseIntelligence_Click(object sender, RoutedEventArgs e)
        {
            unit.Intelligence--;
            unit.Points++;
            DataContext = unit;
        }

        private void IncreaseDexterity_Click(object sender, RoutedEventArgs e)
        {
            unit.Dexterity++;
            unit.Points--;
            DataContext = unit;
        }

        private void DecreaseDexterity_Click(object sender, RoutedEventArgs e)
        {
            unit.Dexterity--;
            unit.Points++;
            DataContext = unit;
        }

        private void IncreaseStrength_Click(object sender, RoutedEventArgs e)
        {
            unit.Strength++;
            unit.Points--;
            DataContext = unit;
           
        }

        private void DecreaseStrength_Click(object sender, RoutedEventArgs e)
        {
            unit.Strength--;
            unit.Points++;
            DataContext = unit;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Peasant();

            image.Content = Resources["Peasant"];

            DataContext = unit;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            unit = new Catapult();

            image.Content = Resources["Catapult"];

            DataContext = unit;
        }
    }
}
