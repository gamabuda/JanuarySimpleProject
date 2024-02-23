using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Unit _unit;
        private Barracks _barracks;
        public MainWindow()
        {
            InitializeComponent();
            Barracks barracks = new Barracks();
            _unit = new Unit();
            DataContext = _unit;
        }

        public class Unit : INotifyPropertyChanged
        {
            Warrior warrior =new Warrior();
            private Unit _unit;
            private Rogue _rogue;
            private Warrior _warrior;
            private Wizzard _wizzard;
            private double _strength;
            private double _vitality;
            private double _dexterity;
            private double _inteligence;

            public Unit unit { get { return _unit; } set { _unit = value; } }
            public Rogue Rogue { get { return _rogue; } set { _rogue = value; } }
            public Warrior Warrior { get { return _warrior; } set { _warrior = value; } }
            public Wizzard  Wizzard { get { return _wizzard; } set { _wizzard = value; } }
            public double Strength
            {
                get { return _strength; }
                set
                {
                    if (_strength != value)
                    {
                        _strength = value;
                        OnPropertyChanged("Strength");
                    }
                }
            }

            public double Vitality
            {
                get { return _vitality; }
                set
                {
                    if (_vitality != value)
                    {
                        _vitality = value;
                        OnPropertyChanged("Vitality");
                    }
                }
            }

            public double Inteligence
            {
                get { return _vitality; }
                set
                {
                    if (_inteligence != value)
                    {
                        _inteligence = value;
                        OnPropertyChanged("Dexterity");
                    }
                }
            }

            public double Dexterity
            {
                get { return _vitality; }
                set
                {
                    if (_dexterity != value)
                    {
                        _dexterity = value;
                        OnPropertyChanged("Dexterity");
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

           
        }
        private void SBTNNplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ahead_Click(object sender, RoutedEventArgs e)
        {
              
        }
    }
}
