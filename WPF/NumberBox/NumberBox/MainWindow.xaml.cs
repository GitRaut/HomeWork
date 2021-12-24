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

namespace NumberBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumBox test = new NumBox();
        public MainWindow()
        {
            InitializeComponent();
            grid.Children.Add(test);
            test.Height = 200;
            test.Width = 300;
            test.Margin = new Thickness(10, 20, 50, 80);
            test.Background = Brushes.Red;
            test.Foreground = Brushes.Green;
        }
    }
}
