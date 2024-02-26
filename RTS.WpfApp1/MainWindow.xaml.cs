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
            unit = new Unit();
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
            unit.Exp += 1000;
            unit.LevelUp();
        }

        private void STRUp(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points > 0 && unit.Strength < unit.MaxStrength)
            {
                unit.Points--;
                unit.Strength++;
                Characteristics(unit);
            }
        }

        private void STRDown(object sender, RoutedEventArgs e)
        {
            if (unit != null && unit.Points < unit.MaxSkillPoints && unit.Strength > unit.DefaultStrength)
            {
                unit.Skillъts++;
                unit.Strength--;
                Characteristics(unit);
            }
        }

        private void Characteristics(Unit unit)
        {
            HPTB.Text = $"Health: {unit.Health} / {unit.MaxHealth}";
            ManaTB.Text = $"Mana: {unit.Mana} / {unit.MaxMana}";
            StrTB.Text = $"Strength: {unit.Strength} / {unit.MaxStrength}";
            DexTB.Text = $"Dexterity: {unit.Dexterity} / {unit.MaxDexterity}";
            IntTB.Text = $"Intelligence: {unit.Intelligence} / {unit.MaxIntelligence}";
            VitTB.Text = $"Vitality: {unit.Vitality} / {unit.MaxVitality}";
            LvlTB.Text = $"Level: {unit.Level} / {unit.MaxLevel}";
        }

        private void DEXUp(object sender, RoutedEventArgs e)
        {

        }

        private void DEXDown(object sender, RoutedEventArgs e)
        {

        }

        private void INTUp(object sender, RoutedEventArgs e)
        {

        }

        private void INTDown(object sender, RoutedEventArgs e)
        {

        }

        private void VITUp(object sender, RoutedEventArgs e)
        {

        }

        private void VITDown(object sender, RoutedEventArgs e)
        {

        }
    }
    }

