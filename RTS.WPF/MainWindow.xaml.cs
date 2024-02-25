using RTS.Core;
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

namespace RTS.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hero = new Warrior();
            UpdateLabel();
            Img.Content = Resources["Warrior"];
        }

        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            hero = new Wizard();
            UpdateLabel();
            Img.Content = Resources["Wizard"];
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            hero = new Rogue();
            UpdateLabel();
            Img.Content = Resources["Rogue"];
        }

        void UpdateLabel()
        {
            if(hero != null)
            {
                SkillPointsInfo.Content = $"SkillPoints: {hero.SkillPoints}";
                MainInformation.Content = $"Class: {hero.ToString().Split('.')[2]}\n" +
                    $"Lvl: {hero.Level}\n" +
                    $"Exp: {hero.Exp}\n" +
                    $"HP: {hero.Health}/{hero.MaxHealth}\n" +
                    $"Mana: {hero.Mana}/{hero.MaxMana}\n";
                Str.Content = $"Strength: {hero.Strength}/{hero.MaxStrength}";
                Dex.Content = $"Dexterity: {hero.Dexterity}/{hero.MaxDexterity}";
                Int.Content = $"Intelligence: {hero.Intelligence}/{hero.MaxIntelligence}";
                Vit.Content = $"Vitality: {hero.Vitality}/{hero.MaxVitality}";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hero.Exp += 1000;
            UpdateLabel();
        }

        private void strPlus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Strength == hero.MaxStrength)
                return;

            if (hero.SkillPoints == 0)
                return;

            hero.Strength += 1;
            hero.SkillPoints -= 1;
            UpdateLabel();
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Dexterity == hero.MaxDexterity)
                return;

            if (hero.SkillPoints == 0)
                return;

            hero.Dexterity += 1;
            hero.SkillPoints -= 1;
            UpdateLabel();
        }

        private void intPlus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Intelligence == hero.MaxIntelligence)
                return;

            if (hero.SkillPoints == 0)
                return;

            hero.Intelligence += 1;
            hero.SkillPoints -= 1;
            UpdateLabel();
        }

        private void vitPlus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Vitality == hero.MaxVitality)
                return;

            if (hero.SkillPoints == 0)
                return;

            hero.Vitality += 1;
            hero.SkillPoints -= 1;
            UpdateLabel();
        }

        private void strMinus_Click(object sender, RoutedEventArgs e)
        {
            if(hero.Strength == hero.BaseStrength) 
                return;

            hero.Strength -= 1;
            hero.SkillPoints += 1;
            UpdateLabel();
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Dexterity == hero.BaseDexterity)
                return;

            hero.Dexterity -= 1;
            hero.SkillPoints += 1;
            UpdateLabel();
        }

        private void intMinus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Intelligence == hero.BaseIntelligence)
                return;

            hero.Intelligence -= 1;
            hero.SkillPoints += 1;
            UpdateLabel();
        }

        private void vitMinus_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Vitality == hero.BaseVitality)
                return;

            hero.Vitality -= 1;
            hero.SkillPoints += 1;
            UpdateLabel();
        }
    }
}