
using RTS.Core;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.WpfApp1
{
    public partial class Window1 : Window
    {

        Unit unit;
        public Window1()
        {
            InitializeComponent();
            this.DataContext = unit;
        }


        private void WarriorRadio_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            this.DataContext = unit;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\i (2).jpeg"));
            CharacterImage.Visibility = Visibility.Visible;
            Characteristics();

        }

        private void WizardRadio_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            this.DataContext = unit;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\i.jpeg"));
            CharacterImage.Visibility = Visibility.Visible;
            Characteristics();

        }

        private void RogueRadio_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            this.DataContext = unit;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\i (1).jpeg"));
            CharacterImage.Visibility = Visibility.Visible;
            Characteristics();

        }
        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            CharacterImage.Visibility = Visibility.Collapsed;
        }

        private void Button_ClickGE(object sender, RoutedEventArgs e)
        {
            unit.Exp += 1000;
            Exp.Text = unit.Exp.ToString();
            unit.LevelUp();
            Characteristics();
        }

        private void Characteristics()
        {
            HPTB.Text = $"Health: {unit.Health} / {unit.MaxHealth}";
            ManaTB.Text = $"Mana: {unit.Mana} / {unit.MaxMana}";
            StrTB.Text = $"Strength: {unit.Strength} / {unit.MaxStrenght}";
            DexTB.Text = $"Dexterity: {unit.Dexterity} / {unit.MaxDexterity}";
            IntTB.Text = $"Intelligence: {unit.Intelligence} / {unit.MaxIntelligence}";
            VitTB.Text = $"Vitality: {unit.Vitality} / {unit.MaxVitality}";
            LvlTB.Text = $"Level: {unit.Level} / {unit.MaxLevel}";
            Exp.Text = unit.Exp.ToString();
            Points.Text = unit.Points.ToString();
        }

        private void STRUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Strength + 1 < unit.MaxStrenght)
            {
                history.Push(unit);
                unit.Points--;
                unit.Strength++;
                Characteristics();
            }

        }

        private void STRDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Strength - 1 >= 30)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Strength--;
                    Characteristics();
                }
            }
            if (unit is Wizard)
            {
                if (unit != null && unit.Strength - 1 >= 15)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Strength--;
                    Characteristics();
                }
            }
            if (unit is Rogue)
            {
                if (unit != null && unit.Strength - 1 >= 20)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Strength--;
                    Characteristics();
                }
            }
        }

        private void DEXUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Dexterity + 1 < unit.MaxDexterity)
            {
                history.Push(unit);
                unit.Points--;
                unit.Dexterity++;
                Characteristics();
            }


        }
        private void DEXDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Dexterity - 1 >= 15)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics();
                }
            }
            if (unit is Wizard)
            {
                if (unit != null && unit.Dexterity - 1 >= 20)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics();
                }
            }
            if (unit is Rogue)
            {
                if (unit != null && unit.Dexterity - 1 >= 30)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics();
                }
            }
        }

        private void INTUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Intelligence + 1 < unit.MaxIntelligence)
            {
                history.Push(unit);
                unit.Points--;
                unit.Intelligence++;
                Characteristics();
            }

        }

        private void INTDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Intelligence - 1 >= 10)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics();
                }
            }

            if (unit is Wizard)
            {
                if (unit != null && unit.Intelligence - 1 >= 35)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics();
                }
            }

            if (unit is Rogue)
            {
                if (unit != null && unit.Intelligence - 1 >= 15)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics();
                }
            }

        }

        private void VITUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Vitality + 1 < unit.MaxVitality)
            {
                history.Push(unit);
                unit.Points--;
                unit.Vitality++;
                Characteristics();
            }

        }

        private void VITDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Vitality - 1 >= 25)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics();
                }
            }

            if (unit is Wizard)
            {
                if (unit != null && unit.Vitality - 1 >= 15)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics();
                }
            }

            if (unit is Rogue)
            {
                if (unit != null && unit.Vitality - 1 >= 20)
                {
                    history.Push(unit);
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics();
                }
            }
        }
        private Stack<Unit> history = new Stack<Unit>();


        private void SaveChangesCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            history.Push(unit);
            Characteristics();
        }

        private void SaveChangesCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Revert changes when the checkbox is unchecked
            // You can implement your own logic here
        }
    }
}

