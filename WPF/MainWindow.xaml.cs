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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Experience = 1700;
        private int Level = 1;
        private const int ExpForLevelUp = 3000;
        private const int MaxLevel = 50;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetExp_Click(object sender, RoutedEventArgs e)
        {
            Experience += 1000;
        }

        private void UpdateExpAndLevel()
        {
            CurrentExp.Text = Experience.ToString();
            CurrentLevel.Text = Level.ToString();

            if (Level >= MaxLevel)
            {
                MessageBox.Show("Максимальный уровень достигнут!");
                return;
            }

             Level++;
             Experience -= ExpForLevelUp;
             CurrentLevel.Text = Level.ToString();
        }
    }
}

