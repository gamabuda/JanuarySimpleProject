using RTS.Core;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Unit unit;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();
            Textblock.Text = unit.ToString();
            ContentPresenter.Content = Resources["wizard"];
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();
            Textblock.Text = unit.ToString();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            unit = new Wizard();
            Textblock.Text = unit.ToString();
        }
    }
}
