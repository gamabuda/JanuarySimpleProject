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

namespace wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("кнопка нажата");
        }

        private void Barracks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("кнопка нажата");
        }

        private void Wizzard_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("кнопка нажата");
        }

        private void Warrior_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
