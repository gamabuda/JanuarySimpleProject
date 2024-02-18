using System.Security.Policy;
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
using Classes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Unit Unit { get { return _unit; } set { _unit = value; DataContext = _unit; DefStatsUpdate(); ElementsUpdate(); } }
        Unit _unit;
        int defStr;
        int defDex;
        int defInt;
        int defVit;

        public MainWindow()
        {
            InitializeComponent();
            Unit = new Warrior();
            DefStatsUpdate();
        }
        private void SwipeLeft(object sender, RoutedEventArgs e)
        {
            if (Unit is Warrior) { Unit = new Rogue(); }
            else if (Unit is Wizard) { Unit = new Warrior(); }
            else if (Unit is Rogue) { Unit = new Wizard(); }
            DefStatsUpdate();
        }

        private void SwipeRight(object sender, RoutedEventArgs e)
        {
            if(Unit is Warrior) { Unit = new Wizard(); }
            else if(Unit is Wizard) { Unit = new Rogue(); }
            else if(Unit is Rogue) {  Unit = new Warrior(); }
            DefStatsUpdate();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ExpAmount.Text = "";
        }

        private void GainExp(object sender, RoutedEventArgs e)
        {
            try
            {
                Unit.Experience += Convert.ToInt32(ExpAmount.Text);
                ElementsUpdate();
            }
            catch
            {
                ExpAmount.Text = "Тут должно быть число!";
            }
        }

        private void StrenghtUp(object sender, RoutedEventArgs e)
        {
            if (Unit.SkillPoints > 0 && Unit.Strenght != Unit.MaxStrenght)
            {
                Unit.SkillPoints -= 1;
                Unit.Strenght += 1;
                ElementsUpdate();
            }
        }

        private void StrenghtDown(object sender, RoutedEventArgs e)
        {
            if(Unit.Strenght - 1 >= defStr)
            {
                Unit.SkillPoints += 1;
                Unit.Strenght -= 1;
                ElementsUpdate();
            }
        }

        private void DexterityUp(object sender, RoutedEventArgs e)
        {
            if (Unit.SkillPoints > 0 && Unit.Dexterity != Unit.MaxDexterity)
            {
                Unit.SkillPoints -= 1;
                Unit.Dexterity += 1;
                ElementsUpdate();
            }
        }

        private void DexterityDown(object sender, RoutedEventArgs e)
        {
            if (Unit.Dexterity - 1 >= defDex)
            {
                Unit.SkillPoints += 1;
                Unit.Dexterity -= 1;
                ElementsUpdate();
            }
        }

        private void IntelligenceUp(object sender, RoutedEventArgs e)
        {
            if (Unit.SkillPoints > 0 && Unit.Intelligence != Unit.MaxIntelligence)
            {
                Unit.SkillPoints -= 1;
                Unit.Intelligence += 1;
                ElementsUpdate();
            }
        }

        private void IntelligenceDown(object sender, RoutedEventArgs e)
        {
            if (Unit.Intelligence - 1 >= defInt)
            {
                Unit.SkillPoints += 1;
                Unit.Intelligence -= 1;
                ElementsUpdate();
            }

        }

        private void VitalityUp(object sender, RoutedEventArgs e)
        {
            if (Unit.SkillPoints > 0 && Unit.Vitality != Unit.MaxVitality)
            {
                Unit.SkillPoints -= 1;
                Unit.Vitality += 1;
                ElementsUpdate();
            }
        }

        private void VitalityDown(object sender, RoutedEventArgs e)
        {
            if (Unit.Vitality - 1 >= defVit)
            {
                Unit.SkillPoints += 1;
                Unit.Vitality -= 1;
                ElementsUpdate();
            }
        }

        private void DefStatsUpdate()
        {
            defStr = Unit.Strenght;
            defDex = Unit.Dexterity;
            defInt = Unit.Intelligence;
            defVit = Unit.Vitality;
        }

        private void ElementsUpdate()
        {
            Name.Content = Unit.Name;
            Strenght.Text = Unit.Strenght.ToString();
            StrPlus.Text = (Unit.Strenght - defStr != 0) ? $"(+{Unit.Strenght - defStr})" : "";
            Dexterity.Text = Unit.Dexterity.ToString();
            DexPlus.Text = (Unit.Dexterity - defDex != 0) ? $"(+{Unit.Dexterity - defDex})" : "";
            Intelligence.Text = Unit.Intelligence.ToString();
            IntPlus.Text = (Unit.Intelligence - defInt != 0) ? $"(+{Unit.Intelligence - defInt})" : "";
            Vitality.Text = Unit.Vitality.ToString();
            VitPlus.Text = (Unit.Vitality - defVit != 0) ? $"(+{Unit.Vitality - defVit})" : "";
            LvlBlock.Text = Unit.Level.ToString();
            ExpBlock.Text = Unit.Experience.ToString();
            SkillPointsBlock.Text = Unit.SkillPoints.ToString();
            if (Unit.Level != 50)
                ExpToNextLvl.Text = $"/{Unit.ExpToNextLvl}";
            else
                ExpToNextLvl.Text = "";
            HpMp.Text = $"HP: {Unit.Health}/{Unit.MaxHealth}{(Unit.MaxHealth - Unit.Health == 0 ? "" : $"(+{Unit.MaxHealth - Unit.Health})")}\tMP: {Unit.Mana}/{Unit.MaxMana}{(Unit.MaxMana - Unit.Mana == 0 ? "" : $"(+{Unit.MaxMana - Unit.Mana})")}";
            HeroIcon.Content = Resources[$"{Unit.Name}"];
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            Unit.Health = Unit.MaxHealth;
            Unit.Mana = Unit.MaxMana;
            DefStatsUpdate();
            ElementsUpdate();
        }
    }
}