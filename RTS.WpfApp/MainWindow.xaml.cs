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
using RTS.Lib;

namespace RTS.WpfApp
{
    public partial class MainWindow : Window
    {
        Unit unit = new Unit();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            unit.Exp = 0;
            this.DataContext = unit;

            TBPerson.Text = "Warrior";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(132, 1, 160, 7);
            TBPerson.VerticalAlignment = VerticalAlignment.Top;
            TBPerson.HorizontalAlignment = HorizontalAlignment.Left;
            TBPerson.Width = 109;
            TBPerson.Height = 33;
            TBPerson.TextWrapping = TextWrapping.Wrap;

            TBHealth.Text = $"Healt: {unit.Health}";
            TBMana.Text = $"Mana: {unit.Mana}";
            TBStrength.Text = $"Strength: {unit.Strength}";
            TBDexterity.Text = $"Dexterity: {unit.Dexterity}";
            TBIntelligence.Text = $"Intelligence: {unit.Intelligence}";
            TBVitality.Text = $"Vitality: {unit.Vitality}";

            HideAllImages();
            ImageWarrior.Visibility = Visibility.Visible;
            TBHealth.Text = $"Health: {unit.Health} / {unit.MaxHealth}";
            TBMana.Text = $"Mana: {unit.Mana} / {unit.MaxMana}";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            unit.Exp = 0;
            this.DataContext = unit;

            TBPerson.Text = "Rogue";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(132, 1, 160, 7);
            TBPerson.VerticalAlignment = VerticalAlignment.Top;
            TBPerson.HorizontalAlignment = HorizontalAlignment.Left;
            TBPerson.Width = 109;
            TBPerson.Height = 33;
            TBPerson.TextWrapping = TextWrapping.Wrap;

            TBHealth.Text = $"Healt: {unit.Health}";
            TBMana.Text = $"Mana: {unit.Mana}";
            TBStrength.Text = $"Strength: {unit.Strength}";
            TBDexterity.Text = $"Dexterity: {unit.Dexterity}";
            TBIntelligence.Text = $"Intelligence: {unit.Intelligence}";
            TBVitality.Text = $"Vitality: {unit.Vitality}";

            HideAllImages();
            ImageRogue.Visibility = Visibility.Visible;
            TBHealth.Text = $"Health: {unit.Health} / {unit.MaxHealth}";
            TBMana.Text = $"Mana: {unit.Mana} / {unit.MaxMana}";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            unit.Exp = 0;
            this.DataContext = unit;

            TBPerson.Text = "Wizard";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(132, 1, 160, 7);
            TBPerson.VerticalAlignment = VerticalAlignment.Top;
            TBPerson.HorizontalAlignment = HorizontalAlignment.Left;
            TBPerson.Width = 109;
            TBPerson.Height = 33;
            TBPerson.TextWrapping = TextWrapping.Wrap;

            TBHealth.Text = $"Healt: {unit.Health}";
            TBMana.Text = $"Mana: {unit.Mana}";
            TBStrength.Text = $"Strength: {unit.Strength}";
            TBDexterity.Text = $"Dexterity: {unit.Dexterity}";
            TBIntelligence.Text = $"Intelligence: {unit.Intelligence}";
            TBVitality.Text = $"Vitality: {unit.Vitality}";

            HideAllImages();
            ImageWizard.Visibility = Visibility.Visible;
            TBHealth.Text = $"Health: {unit.Health} / {unit.MaxHealth}";
            TBMana.Text = $"Mana: {unit.Mana} / {unit.MaxMana}";
        }

        private void HideAllImages()
        {
            foreach (UIElement element in SPImages.Children)
            {
                if (element is Image image)
                {
                    image.Visibility = Visibility.Collapsed;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Lvl >= 50)
            {
                MessageBox.Show("Поздравляем! Вы достигли максимального уровня!");
                return;
            }
            else
            {
                unit.Exp += 1000;
            }
        }

    }
}