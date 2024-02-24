using RTS.Core;
using System;
using System.Reflection.Emit;
using System.Text;
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
        Wizard wizard;
        Rogue rogue;
        Unit unit;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void WarriorRadio_Checked(object sender, RoutedEventArgs e)
        {
            warrior = new Warrior();
            this.DataContext = warrior;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\warriorr.jpg"));
            CharacterImage.Visibility = Visibility.Visible;
            StrTB.Text = $"Strength: {warrior.Strength} / {warrior.MaxStrenght}";
            DexTB.Text = $"Dexterity: {warrior.Dexterity} / {warrior.MaxDexterity}";
            IntTB.Text = $"Intelligence: {warrior.Intelligence} / {warrior.MaxIntelligence}";
            VitTB.Text = $"Vitality: {warrior.Vitality} / {warrior.MaxVitality}";
            LvlTB.Text = $"Level: {warrior.Level} / {warrior.MaxLevel}";


        }

        private void WizardRadio_Checked(object sender, RoutedEventArgs e)
        {
            wizard = new Wizard();
            this.DataContext = wizard;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\wizzard.jpg"));
            CharacterImage.Visibility = Visibility.Visible;
            StrTB.Text = $"Strength: {wizard.Strength} / {wizard.MaxStrenght}";
            DexTB.Text = $"Dexterity: {wizard.Dexterity} / {wizard.MaxDexterity}";
            IntTB.Text = $"Intelligence: {wizard.Intelligence} / {wizard.MaxIntelligence}";
            VitTB.Text = $"Vitality: {wizard.Vitality} / {wizard.MaxVitality}";
            LvlTB.Text = $"Level: {wizard.Level} / {wizard.MaxLevel}";
        }

        private void RogueRadio_Checked(object sender, RoutedEventArgs e)
        {
            rogue = new Rogue();
            this.DataContext = rogue;
            CharacterImage.Source = new BitmapImage(new Uri("C:\\Users\\Asus\\source\\repos\\JanuarySimpleProject\\RTS.WpfApp1\\images\\rogue.jpg"));
            CharacterImage.Visibility = Visibility.Visible;
            StrTB.Text = $"Strength: {rogue.Strength} / {rogue.MaxStrenght}";
            DexTB.Text = $"Dexterity: {rogue.Dexterity} / {rogue.MaxDexterity}";
            IntTB.Text = $"Intelligence: {rogue.Intelligence} / {rogue.MaxIntelligence}";
            VitTB.Text = $"Vitality: {rogue.Vitality} / {rogue.MaxVitality}";
            LvlTB.Text = $"Level: {rogue.Level} / {rogue.MaxLevel}";

        }
        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            CharacterImage.Visibility = Visibility.Collapsed;
        }

        private void Button_ClickLV(object sender, RoutedEventArgs e)
        {
            
        }


        private void Button_ClickGE(object sender, RoutedEventArgs e)
        {

        }
    }
}
