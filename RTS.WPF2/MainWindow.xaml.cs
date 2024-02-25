﻿using System;
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
        
        
           
            public double Vitality
            {
                get { return unit.Vitality; }
                set
                {
                    
                }
            }
            public double Inteligence
            {
                get { return unit.Inteligence; }
                set
                {
                    
                }
            }
            public double Dexterity
            {
                get { return unit.Dexterity; }
                set
                {
                    
                }
            }

            public double Mana
            {
                get { return unit.Mana; }
                set
                {
                   
                }
            }

            public double Strength
            {
                get { return unit.Strength; }
                set
                {
                    
                }
            }

            public int LEVEL
            {
                get { return unit.Level; }
                set
                {
                }
            }

            public double HP
            {
                get { return unit.HP; }
                set
                {

                }
            }



        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            Wizzard wizzard = new Wizzard();
            SN.Text = wizzard.Strength.ToString();
            VN.Text = wizzard.Vitality.ToString();
            IN.Text = wizzard.Inteligence.ToString();
            DN.Text = wizzard.Dexterity.ToString();
            ManaN.Text = wizzard.Mana.ToString();
            LevelN.Text = wizzard.Level.ToString();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            SN.Text = warrior.Strength.ToString();
            VN.Text = warrior.Vitality.ToString();
            IN.Text = warrior.Inteligence.ToString();
            DN.Text = warrior.Dexterity.ToString();
            ManaN.Text = warrior.Mana.ToString();
            LevelN.Text = warrior.Level.ToString();
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            Rogue rogue = new Rogue();
            SN.Text = rogue.Strength.ToString();
            VN.Text = rogue.Vitality.ToString();
            IN.Text = rogue.Inteligence.ToString();
            DN.Text = rogue.Dexterity.ToString();
            ManaN.Text = rogue.Mana.ToString();
            LevelN.Text = rogue.Level.ToString();
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
            
                if (unit.Dexterity == unit.Dexterity++)
                {
                    unit.StartPoint -= 1;
                    unit.Dexterity += 1;
                }
        }

        private void DBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IBTNNplus_Click(object sender, RoutedEventArgs e)
        {
            if (unit.Inteligence == unit.Inteligence++)
            {
                unit.StartPoint -= 1;
                unit.Inteligence += 1;
            }
        }

        private void IBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VBTNNplus_Click(object sender, RoutedEventArgs e)
        {

            
                unit.StartPoint -= 1;
                  unit.Vitality += 1;
            
        }

        private void VBTNNminus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
