using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
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
using System.Xml.Linq;
using RTS.Core;

namespace RTS.WPF2
{
      
    public partial class MainWindow : Window
    {
        
        Unit unit;
        
        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();           
            this.DataContext = unit;
        }
        
        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();
            Class.Text = "Wizard";            
            Picture.Content = Resources["Wizard"];
            this.DataContext = unit;
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            Class.Text = "Warrior";           
            Picture.Content = Resources["Warrior"];
            this.DataContext = unit;

        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            Class.Text = "Rogue";           ;
            Picture.Content = Resources["Rogue"];
            this.DataContext = unit;
        }

        private void SBTNNplus_Click_1(object sender, RoutedEventArgs e)
        {
            if(unit.StartPoint == 0)
            {
                return;
            }
            unit.StartPoint-=1;
            unit.Strength += 1;
        }

        private void SBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            unit.StartPoint += 1;
            unit.Strength -= 1;
        }

        private void DBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.StartPoint == 0)
            {
                return;
            }
            unit.StartPoint -= 1;
            unit.Dexterity += 1;
        }

        private void DBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            unit.StartPoint += 1;
            unit.Dexterity -= 1;
        }

        private void IBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.StartPoint == 0)
            {
                return;
            }
            unit.StartPoint -= 1;
            unit.Inteligence += 1;
        }

        private void IBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            unit.StartPoint += 1;
            unit.Inteligence -= 1;
        }

        private void VBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.StartPoint == 0)
            {
                return;
            }
            unit.StartPoint -= 1;
            unit.Vitality += 1;
        }

        private void VBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            
            unit.StartPoint += 1;
            unit.Vitality -= 1;
        }

        private void XPBTNN_Click(object sender, RoutedEventArgs e)
        {
            unit.XPGained += 1000;
            unit.LevelUp(unit.XPGained);
            unit.StartPoint += 1;

        }
    }
    
}
