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
using System.Threading;

namespace pin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string true_pin = "1096743";
        Color true_color = Color.FromArgb(60, 0, 255, 0);
        Color false_color = Color.FromArgb(60, 255, 0, 0);
        Color normal_color = Color.FromArgb(100, 33, 33, 37);
        static int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "1";
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "2";
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "3";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "4";
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "5";
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "6";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "7";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "8";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text += "9";
            }
        }

        private void nol_Click(object sender, RoutedEventArgs e)
        {
            if(count != 1)
            {
                enter.Text += "0";
            }
        }

        private void cross_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1) {
                enter.Text = null;
            }
        }
        private static readonly Action EmptyDelegate = delegate { };

        private void check_Click(object sender, RoutedEventArgs e)
        {
            if(enter.Text == true_pin && count != 1)
            {
                enter.Text = "TRUE";
                enter.Background = new SolidColorBrush(true_color);
                enter.IsReadOnly = true;
                count = 1;
            }
            else if(count != 1)
            {
                enter.Text = null;
            }
        }

        private void enter_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.D0) && (e.Key <= Key.D9)) e.Handled = false;
            if ((e.Key >= Key.NumPad0) && (e.Key <= Key.NumPad9)) e.Handled = false;
        }
    }
}