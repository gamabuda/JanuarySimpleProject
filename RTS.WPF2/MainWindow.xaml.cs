using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        
        public double Vitaluty
        {
            get { return unit.Vitality; }
            set
            {
                if (unit.Vitality != value)
                {
                    unit.Vitality = value;
                    OnPropertyChanged("Counter");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Wizard_Click(object sender, RoutedEventArgs e)
        {           
            Wizzard wizzard = new Wizzard();         
            ClassN.Text = wizzard.ToString();
            SN.Text = wizzard.Strength.ToString();
            VN.Text = wizzard.Vitality.ToString();
            IN.Text = wizzard.Inteligence.ToString();
            DN.Text = wizzard.Dexterity.ToString();
            ManaN.Text = wizzard.Mana.ToString();
            HPN.Text = wizzard.HP.ToString();
            LevelN.Text = wizzard.Level.ToString();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            ClassN.Text = warrior.ToString();
            SN.Text = warrior.Strength.ToString();
            VN.Text = warrior.Vitality.ToString();
            IN.Text = warrior.Inteligence.ToString();
            DN.Text = warrior.Dexterity.ToString();
            ManaN.Text = warrior.Mana.ToString();
            HPN.Text = warrior.HP.ToString();
            LevelN.Text = warrior.Level.ToString();
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            Rogue rogue = new Rogue();
            ClassN.Text = rogue.ToString();
            SN.Text = rogue.Strength.ToString();
            VN.Text = rogue.Vitality.ToString();
            IN.Text = rogue.Inteligence.ToString();
            DN.Text = rogue.Dexterity.ToString();
            ManaN.Text = rogue.Mana.ToString();
            HPN.Text = rogue.HP.ToString();
            LevelN.Text = rogue.Level.ToString();
            SP.Text = rogue.StartPoint.ToString();
        }

        private void SBTNNplus_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (unit.StartPoint > 0)
            {
                if (unit.Strength == unit.Strength++)
                {
                    unit.StartPoint -= 1;
                    unit.Strength += 1;
                }

                if (unit.Vitality == unit.Vitality++)
                {
                    unit.StartPoint -= 1;
                    unit.Vitality += 1;
                }

                if (unit.Dexterity == unit.Dexterity++)
                {
                    unit.StartPoint -= 1;
                    unit.Dexterity += 1;
                }

                if (unit.Inteligence == unit.Inteligence++)
                {
                    unit.StartPoint -= 1;
                    unit.Inteligence += 1;
                }
            }
        }

        private void SBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            
            if (unit.StartPoint == unit.StartPoint++)
            {

            }
        }

        private void DBTNNplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IBTNNplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VBTNNplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
