using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace YCCustomControl.Controls
{
    public class BoderContent: ContentControl
    {
        public BoderContent()
        {

        }
        public static readonly DependencyProperty HanderProperty = DependencyProperty.Register(
           "Hander", typeof(string), typeof(BoderContent), new PropertyMetadata(default(string)));

        public string Hander
        {
            get => (string)GetValue(HanderProperty);
            set => SetValue(HanderProperty, value);
        }


    }
}
