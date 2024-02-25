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
using System.Xml.Linq;
using RTS.Core;

namespace RTS.WPF2
{

    public partial class MainWindow : INotifyPropertyChanged 
    {
        
        Unit unit = new Unit();
        
        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();
            DataContext = unit;
            this.DataContext = this;
        }
        
        
           
            public double Vitality
            {
                get { return unit.Vitality; }
                set
                {
                    if (unit.Vitality != value)
                    {
                        unit.Vitality = value;
                        OnPropertyChanged("Vitality");
                    }
               
                }
            }
            public double Inteligence
            {
                get { return unit.Inteligence; }
                set
                {
                    if (unit.Inteligence != value)
                    {
                        unit.Inteligence = value;
                        OnPropertyChanged("Inteligence");
                    }
                }
            }
            public double Dexterity
            {
                get { return unit.Dexterity; }
                set
                {
                    if (unit.Dexterity != value)
                    {
                        unit.Dexterity = value;
                        OnPropertyChanged("Dexterity");
                    }
                }
            }

            public double Mana
            {
                get { return unit.Mana; }
                set
                {
                    if (unit.Mana != value)
                    {
                        unit.Mana = value;
                        OnPropertyChanged("Mana");
                    }
                }
            }

            public double Strength
            {
                get { return unit.Strength; }
                set
                {
                    if (unit.Strength != value)
                    {
                        unit.Strength = value;
                        OnPropertyChanged("Strength");
                    }
                }
            }

            public int LEVEL
            {
                get { return unit.Level; }
                set
                {
                    if (unit.Level != value)
                    {
                        unit.Level = value;
                        OnPropertyChanged("Level");
                    }
                }
            }

            public double HP
            {
                get { return unit.HP; }
                set
                {
                    if (unit.HP != value)
                    {
                        unit.HP = value;
                        OnPropertyChanged("HP");
                    }
                }
            }

           
             public int StartPoint
             {
                get { return unit.StartPoint; }
                set
                {
                    if (unit.StartPoint != value)
                    {
                        unit.StartPoint = value;
                        OnPropertyChanged("StartPoint");
                    }
                }
             }

            public int XP
            {
                get { return  unit?.OldXP ?? 0; }
                set
                {
                    if (unit.OldXP != value)
                    {
                        unit.OldXP = value;
                        OnPropertyChanged("XP");
                    }
                }
            }
        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();
            SN.Text = Strength.ToString();
            VN.Text =Vitality.ToString();
            IN.Text = Inteligence.ToString();
            DN.Text = Dexterity.ToString();
            ManaN.Text = Mana.ToString();
            LevelN.Text = LEVEL.ToString();
            XPN.Text = XP.ToString();
            SP.Text =StartPoint.ToString();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            SN.Text = unit.Strength.ToString();
            VN.Text = unit.Vitality.ToString();
            IN.Text = unit.Inteligence.ToString();
            DN.Text = unit.Dexterity.ToString();
            ManaN.Text = unit.Mana.ToString();
            LevelN.Text = unit.Level.ToString();
            XPN.Text = unit.OldXP.ToString();
            SP.Text = unit.StartPoint.ToString();
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            SN.Text = unit.Strength.ToString();
            VN.Text = unit.Vitality.ToString();
            IN.Text = unit.Inteligence.ToString();
            DN.Text = unit.Dexterity.ToString();
            ManaN.Text = unit.Mana.ToString();
            LevelN.Text = unit.Level.ToString();
            XPN.Text = unit.OldXP.ToString();
            SP.Text = unit.StartPoint.ToString();
        }

        private void SBTNNplus_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (StartPoint > 0)
            {             
                    StartPoint -= 1;
                    Strength += 1;            
            }
        }

        private void SBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            
            if (unit.StartPoint == unit.StartPoint++)
            {
                unit.StartPoint += 1;
                unit.Strength -= 1;
            }
        }

        private void DBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            
                if (unit.Dexterity == unit.Dexterity++)
                {
                    unit.StartPoint -= 1;
                    unit.Dexterity += 1;
                }
        }

        private void DBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            unit.StartPoint += 1;
            unit.Dexterity -= 1;
        }

        private void IBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            if (Inteligence == Inteligence++)
            { 
                .StartPoint -= 1;
                Inteligence += 1;
            }
        }

        private void IBTNNminus_Click(object sender, RoutedEventArgs e)
        {
         
            .StartPoint += 1;
            Dexterity -= 1;
        }

        private void VBTNNplus_Click(object sender, RoutedEventArgs e)
        {           
                StartPoint -= 1;
                Vitality += 1;
                
        }

        private void VBTNNminus_Click(object sender, RoutedEventArgs e)
        {
            StartPoint += 1;
            Dexterity -= 1;
        }

        private void XPBTNN_Click(object sender, RoutedEventArgs e)
        {
           XP += 1000;
            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
