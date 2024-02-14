using RTS.Core;
using System.Windows;

namespace RTS.WPF
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
            this.DataContext = unit;
            unit = new Warrior();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit.LevelUp();

            unit.Strength++;
            unit.Inteligence++;
            unit.Vitality++;
            unit.Dexterity++;
            unit.Level++;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();
        }
    }
}
