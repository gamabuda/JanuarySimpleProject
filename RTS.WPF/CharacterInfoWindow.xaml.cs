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
using System.Windows.Shapes;
using RTS.Core.Characters;

namespace RTS.WPF
{
    public partial class CharacterInfoWindow : Window
    {
        private Unit unit;

        public CharacterInfoWindow(Unit unit)
        {
            InitializeComponent();
            this.unit = unit;
            DisplayCharacterInfo();
        }

        private void DisplayCharacterInfo()
        {
            DataContext = unit;
        }

        private void Strength_Click(object sender, RoutedEventArgs e)
        {
            unit.Strength++;
        }

        private void Dexterity_Click(object sender, RoutedEventArgs e)
        {
            unit.Dexterity++;
        }

        private void Intelligence_Click(object sender, RoutedEventArgs e)
        {
            unit.Intelligence++;
        }

        private void Vitality_Click(object sender, RoutedEventArgs e)
        {
            unit.Vitality++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit.GetExperience(100);
        }
    }
}
