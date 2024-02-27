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
        private Unit character;

        public CharacterInfoWindow(Unit character)
        {
            InitializeComponent();
            this.character = character;
            DisplayCharacterInfo();
        }

        private void DisplayCharacterInfo()
        {
            DataContext = character;
        }

        private void Strength_Click(object sender, RoutedEventArgs e)
        {
            character.Strength++;
            UpdateStats();
        }

        private void Dexterity_Click(object sender, RoutedEventArgs e)
        {
            character.Dexterity++;
            UpdateStats();
        }

        private void Intelligence_Click(object sender, RoutedEventArgs e)
        {
            character.Intelligence++;
            UpdateStats();
        }

        private void Vitality_Click(object sender, RoutedEventArgs e)
        {
            character.Vitality++;
            UpdateStats();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            character.GetExperience(1000);
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateStats();
        }

        private void UpdateStats()
        {
            if (character is Warrior warrior)
            {
                warrior.RecalculateStats();
            }
            else if (character is Rogue rogue)
            {
                rogue.RecalculateStats();
            }
            else if (character is Wizard wizard)
            {
                wizard.RecalculateStats();
            }
        }
    }
}
