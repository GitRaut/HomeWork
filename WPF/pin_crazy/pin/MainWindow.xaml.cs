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
using System.Windows.Threading;

namespace pin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int j = 0;
        static int count = 0;
        Random color = new Random();
        Random location = new Random();
        Thickness marg = new Thickness();
        DispatcherTimer timer = new DispatcherTimer();
        Color true_color = Color.FromArgb(60, 0, 255, 0);
        Color false_color = Color.FromArgb(60, 255, 0, 0);
        Color normal_color = Color.FromArgb(100, 33, 33, 37);
        int[] numbers = new int[10]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
            label.HorizontalContentAlignment = HorizontalAlignment.Center;
        }

        private void cross_Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                enter.Text = null;
                marg.Left = 35;
                marg.Top = 10;
                marg.Right = 35;
                enter.Margin = marg;
                foreach (UIElement i in grid.Children)
                {
                    if (i is Button)
                    {
                        Button point = i as Button;
                        point.Content = null;
                    }
                }
            }
        }

        private async void check_Click(object sender, RoutedEventArgs e)
        {
            if (enter.Text.Length == Convert.ToInt32(label.Content) && count != 1)
            {
                enter.Text = "TRUE";
                enter.Background = new SolidColorBrush(true_color);
                enter.IsReadOnly = true;
                count = 1;
            }
            else if (count != 1)
            {
                enter.Background = new SolidColorBrush(false_color);
                enter.Text = "ERROR";
                await Task.Delay(1000);
                enter.Text = null;
                enter.Background = new SolidColorBrush(normal_color);
            }
        }

        private void enter_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.D0) && (e.Key <= Key.D9)) e.Handled = false;
            if ((e.Key >= Key.NumPad0) && (e.Key <= Key.NumPad9)) e.Handled = false;
        }

        private void timerTick(object sender, EventArgs e)
        {
            if(j >= 10)
            {
                j = 0;
            }
            numbers = numbers.OrderBy(num => location.Next()).ToArray();
            foreach (UIElement i in grid.Children)
            {
                if (i is Button && i != cross && i != cross_Copy)
                {
                    Button point = i as Button;
                    point.Content = numbers[j];
                    Random_Color(point);
                    j++;
                }
            }
        }

        private void Random_Color(object sender)
        {
            Button btnn = sender as Button;
            byte redb = (byte)color.Next(20, 255);
            byte blueb = (byte)color.Next(20, 255);
            byte greenb = (byte)color.Next(20, 255);
            btnn.Background = new SolidColorBrush(Color.FromRgb(redb, blueb, greenb));
            byte red = Reverse_Color(redb);
            byte blue = Reverse_Color(blueb);
            byte green = Reverse_Color(greenb);
            btnn.Foreground = new SolidColorBrush(Color.FromRgb(red, blue, green));
        }

        public byte Reverse_Color(int col)
        {
            col = 255 - col;
            col = col <= 20 ? 21 : col;
            col = col > 110 && col < 150 ? (col > 128 ? 60 : 150) : col;
            return Convert.ToByte(col);
        }

        private void _Click(object sender, RoutedEventArgs e)
        {
            if (count != 1)
            {
                int left = Convert.ToInt32(enter.Margin.Left);
                int right = Convert.ToInt32(enter.Margin.Right);
                int top = Convert.ToInt32(enter.Margin.Top);
                int bottom = Convert.ToInt32(enter.Margin.Bottom);
                int shift = location.Next(0, 3);
                switch (shift)
                {
                    case 0:
                        marg.Left = left + 7;
                        break;
                    case 1:
                        marg.Left = right - 7;
                        break;
                    case 2:
                        marg.Top = top + 7;
                        break;
                    case 3:
                        marg.Bottom = bottom + 7;
                        break;
                }
                enter.Margin = marg;
                enter.Text += (sender as Button).Content;
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label.Content = slider.Value;
        }

        private void _PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button che = sender as Button;
            if (count != 1 && che.Content != null)
            {
                List<Button> buttons = new List<Button>() { one, two, three, four, five, six, seven, eight, nine, nol };
                int second_index = location.Next(buttons.Count);
                Button btn1 = sender as Button;
                Button btn2 = buttons[second_index];
                string content1 = btn1.Content.ToString();
                string content2 = btn2.Content.ToString();
                btn1.Content = content2;
                btn2.Content = content1;
            }
        }
    }
}