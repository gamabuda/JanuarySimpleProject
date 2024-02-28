using RTS.Core;
using System.Windows.Media.Imaging;
using System.Windows;
using RTS.Core.Units;
using System.Threading;

namespace WPF
{
    public partial class MainWindow : Window
    {
        Unit unit = new Unit();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\User\\Desktop\\WPF\\WPF\\images\\warrior.png", UriKind.Relative));
            CharacterImage.Visibility = Visibility.Visible;
            SetCharacterProperties(warrior, "WARRIOR");
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            Rogue rogue = new Rogue();
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\User\\Desktop\\WPF\\WPF\\images\\rogue.png", UriKind.Relative));
            CharacterImage.Visibility = Visibility.Visible;
            SetCharacterProperties(rogue, "ROGUE");
        }

        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard();
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\User\\Desktop\\WPF\\WPF\\images\\wizard.png", UriKind.Relative));
            CharacterImage.Visibility = Visibility.Visible;
            SetCharacterProperties(wizard, "WIZARD");
        }

        private void SetCharacterProperties(Unit character, string characterName)
        {
            MinStr.Text = $"{character.MinStrength}";
            MaxStr.Text = $"{character.MaxStrength}";
            MinDex.Text = $"{character.MinDexterity}";
            MaxDex.Text = $"{character.MaxDexterity}";
            MinInt.Text = $"{character.MinIntelligence}";
            MaxInt.Text = $"{character.MaxIntelligence}";
            MinVit.Text = $"{character.MinVitality}";
            MaxVit.Text = $"{character.MaxVitality}";
            CurrentLevel.Text = $"{character.Level}";
            CurrentExp.Text = $"{character.Experience}";
            Points.Text = $"{character.Points}";
            Health.Text = $"{character.Health}";
            MaxHealth.Text = $"{character.MaxHealth}";
            Mana.Text = $"{character.Mana}";
            MaxMana.Text = $"{character.MaxMana}";

            CharacterBT.Text = characterName;
            
        }


        private void GetExp_Click(object sender, RoutedEventArgs e)
        {
            unit.Experience += 1000;
            CurrentExp.Text = $"{unit.Experience}";
            unit.LevelUp();
            CurrentLevel.Text = $"{unit.Level}";
            Points.Text = $"{unit.Points}";
        }

        private void StrPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinStrength == unit.MaxStrength || unit.Points == 0)
                return;

            unit.MinStrength++;
            unit.Points--;
            MinStr.Text = $"{unit.MinStrength}";
            Points.Text = $"{unit.Points}";
        }

        private void StrMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinStrength == unit.MinStrength || unit.Points == 0)
                return;
            unit.MinStrength--;
            unit.Points++;
            MinStr.Text = $"{unit.MinStrength}";
            Points.Text = $"{unit.Points}";
        }

        private void DexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinDexterity == unit.MaxDexterity || unit.Points == 0)
                return;
            unit.MinDexterity++;
            unit.Points--;
            MinDex.Text = $"{unit.MinDexterity}";
            Points.Text = $"{unit.Points}";
        }

        private void DexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinDexterity == unit.MinDexterity || unit.Points == 0)
                return;
            unit.MinDexterity--;
            unit.Points++;
            MinDex.Text = $"{unit.MinDexterity}";
            Points.Text = $"{unit.Points}";
        }

        private void IntPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinIntelligence == unit.MaxIntelligence || unit.Points == 0)
                return;
            unit.MinIntelligence++;
            unit.Points--;
            MinInt.Text = $"{unit.MinIntelligence}";
            Points.Text = $"{unit.Points}";
        }

        private void IntMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinIntelligence == unit.MinIntelligence || unit.Points == 0)
                return;
            unit.MinIntelligence--;
            unit.Points++;
            MinInt.Text = $"{unit.MinIntelligence}";
            Points.Text = $"{unit.Points}";
        }

        private void VitPlus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinVitality == unit.MaxVitality || unit.Points == 0)
                return;
            unit.MinVitality++;
            unit.Points--;
            MinVit.Text = $"{unit.MinVitality}";
            Points.Text = $"{unit.Points}";
        }

        private void VitMinus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.MinVitality == unit.MinVitality || unit.Points == 0)
                return;
            unit.MinVitality--;
            unit.Points++;
            MinVit.Text = $"{unit.MinVitality}";
            Points.Text = $"{unit.Points}";
        }
    }
}
