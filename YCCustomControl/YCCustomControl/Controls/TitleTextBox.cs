using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace YCCustomControl.Controls
{
    public class TitleTextBox:TextBox
    {
        public TitleTextBox()
        {
            TxtWidth = 145;
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
         "Title", typeof(string), typeof(TitleTextBox), new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public static readonly DependencyProperty DescribeProperty = DependencyProperty.Register(
     "Describe", typeof(string), typeof(TitleTextBox), new PropertyMetadata(default(string)));

        public string Describe
        {
            get => (string)GetValue(DescribeProperty);
            set => SetValue(DescribeProperty, value);
        }

        public static readonly DependencyProperty TitleWidthProperty = DependencyProperty.Register("TitleWidth", typeof(int), typeof(TitleTextBox), new FrameworkPropertyMetadata(70));

        public int TitleWidth
        {
            get => (int)GetValue(TitleWidthProperty);
            set => SetValue(TitleWidthProperty, value);
        }

        public static readonly DependencyProperty TxtWidthProperty = DependencyProperty.Register("TxtWidth", typeof(int), typeof(TitleTextBox), new FrameworkPropertyMetadata(145));

        public int TxtWidth
        {
            get => (int)GetValue(TxtWidthProperty);
            set => SetValue(TxtWidthProperty, value);
        }
        
    }
}
