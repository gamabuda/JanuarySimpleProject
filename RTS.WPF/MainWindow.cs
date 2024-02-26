using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RTS.WPF
{
    public partial class MainWindow : Window
    {
        private void strPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Strenght1 == Strenght3)
                return;
            else
                Strenght1 += 1;
        }
    }
}