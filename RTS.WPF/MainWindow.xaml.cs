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
            unit = new Unit();
            this.DataContext = unit;

        }

        public object PropertyChanged { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit.Experience = unit.Experience + 1000;
            unit.LevelUp();

            unit.Strength++;
            unit.Inteligence++;
            unit.Vitality++;
            unit.Dexterity++;
            this.DataContext = unit;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            this.DataContext = unit;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            this.DataContext = unit;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();
            this.DataContext = unit;
        }
    }
}
