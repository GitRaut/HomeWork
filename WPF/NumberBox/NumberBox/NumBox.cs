using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NumberBox
{
    class NumBox : UIElement
    {
        private Button[] btns = new Button[2];
        private Label field;
        int content;
        private double width;
        private double height;
        public Thickness margin;
        Brush background;
        Brush foreground;

        public NumBox()
        {
            field = new Label();
            btns[0] = new Button();
            btns[1] = new Button();
            field.Content = 0;
            btns[0].Content = "↑";
            btns[1].Content = "↓";
            btns[0].Click += Click;
            btns[1].Click += Click;
            field.HorizontalContentAlignment = HorizontalAlignment.Center;
            field.VerticalContentAlignment = VerticalAlignment.Center;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(field.Content);
            if ((sender as Button) == btns[0])
            {
                field.Content = num + 1;
            }
            else
            {
                field.Content = num - 1;
            }
        }

        override protected void OnVisualParentChanged(DependencyObject oldParent)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(field);
            grid.Children.Add(btns[0]);
            grid.Children.Add(btns[1]);
        }

        public int Content
        {
            get { return content; }
            set
            {
                content = value;
                field.Content = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                field.Width = value - (value / 4);
                btns[0].Width = value / 4;
                btns[1].Width = value / 4;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                field.Height = value;
                field.FontSize = value / 2;
                btns[0].Height = value / 2;
                btns[1].Height = value / 2;
                btns[0].FontSize = value / 4;
                btns[1].FontSize = value / 4;
            }
        }

        public Thickness Margin
        {
            get { return margin; }
            set
            {
                margin = value;
                Thickness temp = value;
                temp.Top -= height / 2;
                temp.Left += width;
                field.Margin = value;
                btns[0].Margin = temp;
                temp.Top += height;
                btns[1].Margin = temp;
            }
        }

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                field.Background = value;
                btns[0].Background = value;
                btns[1].Background = value;
            }
        }

        public Brush Foreground
        {
            get { return foreground; }
            set
            {
                foreground = value;
                field.Foreground = value;
                btns[0].Foreground = value;
                btns[1].Foreground = value;
            }
        }
    }
}
