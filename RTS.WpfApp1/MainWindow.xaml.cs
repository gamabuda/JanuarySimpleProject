using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RTS.WpfApp1
{
    public partial class MainWindow : Window
    {
        Warrior warrior;
        public MainWindow()
        {
            InitializeComponent();
            Warrior warrior = new Warrior();
            this.DataContext = warrior;
            StrTB.Text = warrior.Strength.ToString();
            DexTB.Text = warrior.Dexterity.ToString();
            IntTB.Text = warrior.Intelligence.ToString();
            VitTB.Text = warrior.Vitality.ToString();
            LvlTB.Text = warrior.Level.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            warrior.LevelUp(warrior);
            warrior.Strength++;
            warrior.Dexterity++;
            warrior.Intelligence++;
            warrior.Vitality++;
        }
    }
}
