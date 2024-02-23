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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Unit unit = new Unit();
        public MainWindow()
        {
            InitializeComponent();
            //unit = new Warrior();
            //this.DataContext = unit;


            //StrTB.Text = warrior.Strength.ToString();
            //DexTB.Text = warrior.Dexterity.ToString();
            //IntTB.Text = warrior.Inteligence.ToString();
            //VitTB.Text = warrior.Vitality.ToString();
            //LvlTB.Text = warrior.Level.ToString();
        }

        //public object PropertyChanged { get; private set; }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    unit.LevelUp(unit);

        //    unit.Strength++;
        //    unit.Dexterity++;
        //    unit.Intelligence++;
        //    unit.Vitality++;
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    unit = new Warrior();
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    unit = new Rogue();
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    unit = new Wizard();
        //}
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            this.DataContext = unit;

            TBPerson.Text = "Warrior";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(139, 41, 0, 0);
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

            ImageWarrior.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            this.DataContext = unit;

            TBPerson.Text = "Rogue";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(139, 41, 0, 0);
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

            ImageWarrior.Visibility = Visibility.Collapsed;
            ImageRogue.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            this.DataContext = unit;

            TBPerson.Text = "Wizard";
            TBPerson.FontSize = 30;
            TBPerson.FontWeight = FontWeights.Bold;
            TBPerson.Margin = new Thickness(139, 41, 0, 0);
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

            
            ImageRogue.Visibility = Visibility.Collapsed;
            ImageWizard.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для получения опыта здесь
        }

    }
}