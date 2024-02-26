using RTS.Core;
using System;
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
    public partial class MainWindow : Window
    {
        
        Unit unit;
        public MainWindow()
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
            Characteristics(unit);

        }

        private void WizardRadio_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            this.DataContext = unit;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\i.jpeg"));
            CharacterImage.Visibility = Visibility.Visible;
            Characteristics(unit);

        }

        private void RogueRadio_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            this.DataContext = unit;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\i (1).jpeg"));
            CharacterImage.Visibility = Visibility.Visible;
            Characteristics(unit);

        }
        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            CharacterImage.Visibility = Visibility.Collapsed;
        }


        private void Button_ClickGE(object sender, RoutedEventArgs e)
        {
            GetExp(unit);
        }

        private void GetExp(Unit unit)
        {
                unit.NecessaryExp = (unit.Level - 1) * 1000;

                if (unit.Level < unit.MaxLevel)
                {

                    if (unit.Exp < unit.NecessaryExp)
                    {
                        MessageBox.Show($"Недостаточно опыта для повышения уровня: {unit.NecessaryExp}");
                        return;
                    }

                    unit.Level++;
                    unit.Exp -= unit.NecessaryExp;
                    unit.Points += 1;
                    Characteristics(unit);
                    MessageBox.Show($"Поздравляем, вы достигли уровня {unit.Level}! Текущий опыт: {unit.Exp}");
                }
                else
                {
                    MessageBox.Show("Вы достигли максимального уровня! Поздравляем!");
                }
        }
        

        private void STRUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Strength + 1 < unit.MaxStrenght)
            {
                unit.Points--;
                unit.Strength++;
                Characteristics(unit);
            }
            
        }

        private void STRDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior) 
            {
                if ( unit != null && unit.Strength - 1 >= 30)
                {
                    unit.Points++;
                    unit.Strength--;
                    Characteristics(unit);
                }
            }
            if (unit is Wizard)
            {
                if (unit != null && unit.Strength - 1 >= 15)
                {
                    unit.Points++;
                    unit.Strength--;
                    Characteristics(unit);
                }
            }
            if (unit is Rogue)
            {
                if (unit != null && unit.Strength - 1 >= 20)
                {
                    unit.Points++;
                    unit.Strength--;
                    Characteristics(unit);
                }
            }
        }

        private void Characteristics(Unit unit)
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

        private void DEXUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Dexterity + 1 < unit.MaxDexterity)
            {
                unit.Points--;
                unit.Dexterity++;
                Characteristics(unit);
            }
            

        }
        private void DEXDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Dexterity - 1 >= 15)
                {
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics(unit);
                }
            }
            if (unit is Wizard)
            {
                if (unit != null && unit.Dexterity - 1 >= 20)
                {
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics(unit);
                }
            }
            if (unit is Rogue)
            {
                if (unit != null && unit.Dexterity - 1 >= 30)
                {
                    unit.Points++;
                    unit.Dexterity--;
                    Characteristics(unit);
                }
            }
        }

        private void INTUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Intelligence + 1 < unit.MaxIntelligence)
            {
                unit.Points--;
                unit.Intelligence++;
                Characteristics(unit);
            }
            
        }

        private void INTDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Intelligence - 1 >= 10)
                {
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics(unit);
                }
            }

            if (unit is Wizard)
            {
                if (unit != null && unit.Intelligence - 1 >= 35)
                {
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics(unit);
                }
            }

            if (unit is Rogue)
            {
                if (unit != null && unit.Intelligence - 1 >= 15)
                {
                    unit.Points++;
                    unit.Intelligence--;
                    Characteristics(unit);
                }
            }

        }

        private void VITUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Vitality + 1 < unit.MaxVitality)
            {
                unit.Points--;
                unit.Vitality++;
                Characteristics(unit);
            }
           
        }

        private void VITDown(object sender, RoutedEventArgs e)
        {
            if (unit is Warrior)
            {
                if (unit != null && unit.Vitality - 1 >= 25)
                {
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics(unit);
                }
            }

            if (unit is Wizard)
            {
                if (unit != null && unit.Vitality - 1 >= 15)
                {
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics(unit);
                }
            }

            if (unit is Rogue)
            {
                if (unit != null && unit.Vitality - 1 >= 20)
                {
                    unit.Points++;
                    unit.Vitality--;
                    Characteristics(unit);
                }
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    }

