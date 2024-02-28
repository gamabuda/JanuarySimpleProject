using RTS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RTS.WPF
{
    public partial class MainWindow : Window
    {
        Unit unit;
        public MainWindow()
        {
            InitializeComponent();
            unit = new Unit();
            DataContext = unit;
        }

        private void Button_Warrior(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            DataContext = unit;
            image.Content = Resources["Warrior"];         
        }
        private void Button_Wizard(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            DataContext = unit;
            image.Content = Resources["Wizard"];
        }
        private void Button_Rogue(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            DataContext = unit;
            image.Content = Resources["Rogue"];
        }

        private void SPlus(object sender, RoutedEventArgs e)
        {

            if (unit.Strenght > 0 && unit.Strenght < unit.MaxStrenght && unit.Points > 0)
            {
                unit.Strenght++;
                unit.Points--;
            }
        }
        private void DPlus(object sender, RoutedEventArgs e)
        {

            if (unit.Dexterity > 0 && unit.Dexterity < unit.MaxDexterity && unit.Points > 0)
            {
                unit.Dexterity++;
                unit.Points--;
            }
        }
        private void IPlus(object sender, RoutedEventArgs e)
        {

            if (unit.Inteligense > 0 && unit.Inteligense < unit.MaxInteligense && unit.Points > 0)
            {
                unit.Inteligense++;
                unit.Points--;
            }
        }
        private void VPlus(object sender, RoutedEventArgs e)
        {

            if (unit.Vitality > 0 && unit.Vitality < unit.MaxVitality && unit.Points > 0)
            {
                unit.Vitality++;
                unit.Points--;
            }
        }

        private void SMinus(object sender, RoutedEventArgs e)
        {

            if (unit.Strenght > 0 && unit.Strenght < unit.MaxStrenght && unit.Points > 0)
            {
                unit.Strenght--;
                unit.Points++;
            }
        }
        private void DMinus(object sender, RoutedEventArgs e)
        {

            if (unit.Dexterity > 0 && unit.Dexterity < unit.MaxDexterity && unit.Points > 0)
            {
                unit.Dexterity--;
                unit.Points++;
            }
        }
        private void IMinus(object sender, RoutedEventArgs e)
        {

            if (unit.Inteligense > 0 && unit.Inteligense < unit.MaxInteligense && unit.Points > 0)
            {
                unit.Inteligense--;
                unit.Points++;
            }
        }
        private void VMinus(object sender, RoutedEventArgs e)
        {

            if (unit.Vitality > 0 && unit.Vitality < unit.MaxVitality && unit.Points > 0)
            {
                unit.Vitality--;
                unit.Points++;
            }
        }


        //    private void strPlus_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (Strenght1 == Strenght3)
        //            return;
        //        else
        //            unit.Strength1 += 1;
        //    }
        //}

        //public class Warrior
        //{
        //    public string Strenght1
        //    {
        //        get { return Strenght1; }
        //        set
        //        {
        //            if (Strenght1 != value)
        //            {
        //                Strenght1 = value;
        //                OnPropertyChanged("Strenght1");
        //            }
        //        }
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;
        //    protected virtual void OnPropertyChanged(string propertyName)
        //    {
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}