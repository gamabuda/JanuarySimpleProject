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
        Unit unit;
        public MainWindow()
        {
            InitializeComponent();
            unit = new Warrior();
            this.DataContext = unit;


            //StrTB.Text = warrior.Strength.ToString();
            //DexTB.Text = warrior.Dexterity.ToString();
            //IntTB.Text = warrior.Inteligence.ToString();
            //VitTB.Text = warrior.Vitality.ToString();
            //LvlTB.Text = warrior.Level.ToString();
        }

        public object PropertyChanged { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unit.LevelUp(unit);

            unit.Strength++;
            unit.Dexterity++;
            unit.Intelligence++;
            unit.Vitality++;
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
            unit = new Wizard();
        }
    }
}