using System;
using System.Collections.Generic;
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

namespace CharacterEdit.Pages
{
    /// <summary>
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public int ClassIndex = -1;
        public CharacterPage()
        {
            InitializeComponent();
            LevelTb.Text = "0";
            StatPointsTb.Text = "0";
            CurrentExpTb.Text = "0";
            MaxExpTb.Text = "0";
            CurrentHPTb.Text = "0";
            CurrentManaTb.Text = "0";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ClassComb.SelectedIndex;
            ClassIndex = index;
            if (ClassIndex == 0)
            {
                WarriorImage.Visibility = Visibility.Visible;
                RogueImage.Visibility = Visibility.Collapsed;
                WizardImage.Visibility = Visibility.Collapsed;
                MaxStrTb.Text = "250";
                MaxDexTb.Text = "80";
                MaxIntTb.Text = "50";
                MaxVitTb.Text = "100";
                StrTb.Text = "30";
                DexTb.Text = "15";
                IntTb.Text = "10";
                VitTb.Text = "25";
            }
            else if (ClassIndex == 1)
            {
                WarriorImage.Visibility = Visibility.Collapsed;
                RogueImage.Visibility = Visibility.Visible;
                WizardImage.Visibility = Visibility.Collapsed;
                MaxStrTb.Text = "65";
                MaxDexTb.Text = "250";
                MaxIntTb.Text = "70";
                MaxVitTb.Text = "80";
                StrTb.Text = "20";
                DexTb.Text = "30";
                IntTb.Text = "15";
                VitTb.Text = "20";
            }
            else if (ClassIndex == 2)
            {
                WarriorImage.Visibility = Visibility.Collapsed;
                RogueImage.Visibility = Visibility.Collapsed;
                WizardImage.Visibility = Visibility.Visible;
                MaxStrTb.Text = "45";
                MaxDexTb.Text = "80";
                MaxIntTb.Text = "250";
                MaxVitTb.Text = "70";
                StrTb.Text = "15";
                DexTb.Text = "20";
                IntTb.Text = "35";
                VitTb.Text = "15";
            }
            Refresh();
        }

        public void Refresh()
        {
            if (ClassIndex == 0)
            {
                MaxHPTb.Text = (int.Parse(MaxVitTb.Text) * 2 + int.Parse(MaxStrTb.Text)).ToString();
                CurrentHPTb.Text = MaxHPTb.Text;
                MaxManaTb.Text = int.Parse(MaxIntTb.Text).ToString();
                CurrentManaTb.Text = MaxManaTb.Text;

                PDamageTb.Text = int.Parse(MaxStrTb.Text).ToString();
                ArmorTb.Text = int.Parse(MaxDexTb.Text).ToString();
                MDamageTb.Text = ((Math.Round(int.Parse(MaxIntTb.Text) * 0.2))).ToString();
                MDefenceTb.Text = ( (Math.Round(int.Parse(MaxIntTb.Text) * 0.5))).ToString();

                CrtChanceTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.2))).ToString();
                CrtDamageTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.1))).ToString();
            }
            else if (ClassIndex == 1)
            {
                MaxHPTb.Text = (Math.Round(int.Parse(MaxVitTb.Text) * 1.5) + Math.Round(int.Parse(MaxStrTb.Text) * 0.5)).ToString();
                CurrentHPTb.Text = MaxHPTb.Text;
                MaxManaTb.Text = Math.Round(int.Parse(MaxIntTb.Text) * 1.2).ToString();
                CurrentManaTb.Text = MaxManaTb.Text;

                PDamageTb.Text = (Math.Round(int.Parse(MaxStrTb.Text) * 0.5) + Math.Round(int.Parse(MaxDexTb.Text) * 0.5)).ToString();
                ArmorTb.Text = (Math.Round(int.Parse(MaxDexTb.Text) * 1.5)).ToString();
                MDamageTb.Text = ((Math.Round(int.Parse(MaxIntTb.Text) * 0.2))).ToString();
                MDefenceTb.Text = ((Math.Round(int.Parse(MaxIntTb.Text) * 0.5))).ToString();

                CrtChanceTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.2))).ToString();
                CrtDamageTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.1))).ToString();
            }
            else if (ClassIndex == 2)
            {
                MaxHPTb.Text = (Math.Round(int.Parse(MaxVitTb.Text) * 1.4) + Math.Round(int.Parse(MaxStrTb.Text) * 0.2)).ToString();
                CurrentHPTb.Text = MaxHPTb.Text;
                MaxManaTb.Text = Math.Round(int.Parse(MaxIntTb.Text) * 1.5).ToString();
                CurrentManaTb.Text = MaxManaTb.Text;

                PDamageTb.Text = (Math.Round(int.Parse(MaxStrTb.Text) * 0.5)).ToString();
                ArmorTb.Text = int.Parse(MaxDexTb.Text).ToString();
                MDamageTb.Text = int.Parse(MaxIntTb.Text).ToString();
                MDefenceTb.Text = int.Parse(MaxIntTb.Text).ToString();

                CrtChanceTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.2))).ToString();
                CrtDamageTb.Text = ((Math.Round(int.Parse(MaxDexTb.Text) * 0.1))).ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ClassIndex != -1 && App.CanUpgrade == false && NameTb.Text != "")
            {
                LevelTb.Text = "1";
                MaxExpTb.Text = "1000";
                NameTb.IsEnabled = false;
                ClassComb.IsEnabled = false;
                App.CanUpgrade = true;
            }
            else if (ClassIndex == -1) MessageBox.Show("Сначала выберите класс своего персонажа");
            else if (NameTb.Text == "") MessageBox.Show("Выберите имя персонажу");
            else if (App.CanUpgrade == true) MessageBox.Show("Вы уже сохранили персонажа");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                int CurrentExp = int.Parse(CurrentExpTb.Text);
                CurrentExp += 1000;
                if (CurrentExp >= int.Parse(MaxExpTb.Text))
                {
                    CurrentExpTb.Text = (CurrentExp - int.Parse(MaxExpTb.Text)).ToString();
                    MaxExpTb.Text = (int.Parse(MaxExpTb.Text) + 1000).ToString();
                    LevelTb.Text = (int.Parse(LevelTb.Text) + 1).ToString();
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MessageBox.Show($"Новый уровень: {LevelTb.Text}!");
                }
                else CurrentExpTb.Text = CurrentExp.ToString();
                if (LevelTb.Text == "50") GiveExpButton.IsEnabled = false;
            }
            else MessageBox.Show("Сначала выберите класс героя и нажмите сохранить");
        }

        private void PlusStrButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (StatPointsTb.Text != "0")
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) - 1).ToString();
                    MaxStrTb.Text = (int.Parse(MaxStrTb.Text) + 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вам не хватает очков прокачки");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void MinusStrButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (ClassIndex == 0 && int.Parse(MaxStrTb.Text) > 250)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxStrTb.Text = (int.Parse(MaxStrTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 1 && int.Parse(MaxStrTb.Text) > 65)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxStrTb.Text = (int.Parse(MaxStrTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 2 && int.Parse(MaxStrTb.Text) > 45)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxStrTb.Text = (int.Parse(MaxStrTb.Text) - 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вы не можете уменьшить силу меньше базового значения");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void PlusDexButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (StatPointsTb.Text != "0")
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) - 1).ToString();
                    MaxDexTb.Text = (int.Parse(MaxDexTb.Text) + 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вам не хватает очков прокачки");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void MinusDexButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (ClassIndex == 0 && int.Parse(MaxDexTb.Text) > 80)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxDexTb.Text = (int.Parse(MaxDexTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 1 && int.Parse(MaxDexTb.Text) > 250)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxDexTb.Text = (int.Parse(MaxDexTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 2 && int.Parse(MaxDexTb.Text) > 80)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxDexTb.Text = (int.Parse(MaxDexTb.Text) - 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вы не можете уменьшить ловкость меньше базового значения");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void PlusIntButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (StatPointsTb.Text != "0")
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) - 1).ToString();
                    MaxIntTb.Text = (int.Parse(MaxIntTb.Text) + 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вам не хватает очков прокачки");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void PlusVitButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (StatPointsTb.Text != "0")
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) - 1).ToString();
                    MaxVitTb.Text = (int.Parse(MaxVitTb.Text) + 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вам не хватает очков прокачки");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void MinusIntButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (ClassIndex == 0 && int.Parse(MaxIntTb.Text) > 50)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxIntTb.Text = (int.Parse(MaxIntTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 1 && int.Parse(MaxIntTb.Text) > 70)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxIntTb.Text = (int.Parse(MaxIntTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 2 && int.Parse(MaxIntTb.Text) > 250)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxIntTb.Text = (int.Parse(MaxIntTb.Text) - 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вы не можете уменьшить ум меньше базового значения");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }

        private void MinusVitButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CanUpgrade == true)
            {
                if (ClassIndex == 0 && int.Parse(MaxVitTb.Text) > 100)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxVitTb.Text = (int.Parse(MaxVitTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 1 && int.Parse(MaxVitTb.Text) > 80)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxVitTb.Text = (int.Parse(MaxVitTb.Text) - 5).ToString();
                    Refresh();
                }
                else if (ClassIndex == 2 && int.Parse(MaxVitTb.Text) > 70)
                {
                    StatPointsTb.Text = (int.Parse(StatPointsTb.Text) + 1).ToString();
                    MaxVitTb.Text = (int.Parse(MaxVitTb.Text) - 5).ToString();
                    Refresh();
                }
                else MessageBox.Show("Вы не можете уменьшить выносливость меньше базового значения");
            }
            else MessageBox.Show("Вы еще не сохранили персонажа");
        }
    }
}
