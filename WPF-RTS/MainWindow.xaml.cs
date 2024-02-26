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
using RTS;
using RTS.Bildings;
using RTS.Units;

namespace WPF_RTS
{

    public partial class MainWindow : Window
    {
        Unit unit;

        int minstr;
        int mindex;
        int minint;
        int minvit;

        
        public MainWindow()
        {
            InitializeComponent();

            unit = new Warrior();
            minstr = unit.Strength;
            mindex = unit.Dexterity;
            minvit = unit.Vitality;
            minint = unit.Inteligence;

            this.DataContext = unit;
        }
        private void StrengthUp(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints > 0) 
            {
                unit.Strength++;
                unit.LevelingPoints--;
            }
            unit.CheckingAttributes();
        }

        private void StrengthDown(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints < unit.AllLevelingPoints && unit.Strength > minstr)
            {
                unit.Strength--;
                unit.LevelingPoints++;
            }
            unit.CheckingAttributes();

        }

        private void DexterityUp(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints > 0)
            {
                unit.Dexterity++;
                unit.LevelingPoints--;
            }
            unit.CheckingAttributes();

        }

        private void DexterityDown(object sender, RoutedEventArgs e)
        {
            if(unit.LevelingPoints < unit.AllLevelingPoints && unit.Dexterity > mindex)
            {
                unit.Dexterity--;
                unit.LevelingPoints++;
            }
            unit.CheckingAttributes();

        }

        private void InteligenceDown(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints < unit.AllLevelingPoints && unit.Inteligence > minint)
            {
                unit.Inteligence--;
                unit.LevelingPoints++;
            }
            unit.CheckingAttributes();

        }

        private void InteligenceUp(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints > 0)
            {
                unit.Inteligence++;
                unit.LevelingPoints--;
            }
            unit.CheckingAttributes();

        }

        private void VitalityDown(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints < unit.AllLevelingPoints && unit.Vitality > minvit)
            {
                unit.Vitality--;
                unit.LevelingPoints++;
            }
            unit.CheckingAttributes();

        }

        private void VitalityUp(object sender, RoutedEventArgs e)
        {
            if (unit.LevelingPoints > 0)
            {
                unit.Vitality++;
                unit.LevelingPoints--;
            }
            unit.CheckingAttributes();

        }

        private void GetEXPButton(object sender, RoutedEventArgs e)
        {
            unit.LevelUp(1000);
            UpdateValues();
        }

        private void PreviousCharacter(object sender, RoutedEventArgs e)
        {
            if (unit.Class == "Warrior")
            {
                unit = new Rogue();
                HeroIcon.Content = Resources["Rogue"];
            }
            else if (unit.Class == "Wizard")
            {
                unit = new Warrior();
            }
            else if (unit.Class == "Rogue")
            {
                unit = new Wizard();
            }
            UpdateValues();
        }

        private void NextCharacter(object sender, RoutedEventArgs e)
        {
            if (unit.Class == "Warrior")
            {
                unit = new Wizard();
            }
            else if (unit.Class == "Wizard")
            {
                unit = new Rogue();
            }
            else if (unit.Class == "Rogue")
            {
                unit = new Warrior();
            }
            UpdateValues();
        }

        private void UpdateValues()
        {
            Strength.Text = unit.Strength.ToString();
            Dexterity.Text = unit.Dexterity.ToString();
            Inteligence.Text = unit.Inteligence.ToString();
            Vitality.Text = unit.Vitality.ToString();
            Class.Text = unit.Class.ToString();
            Level.Text = unit.Level.ToString();
            EXP.Text = unit.CurrentExperience.ToString();
            Health.Text = unit.Health.ToString();
            Mana.Text = unit.Mana.ToString();
            LevelingPoints.Text = unit.LevelingPoints.ToString();
        }
    }
}