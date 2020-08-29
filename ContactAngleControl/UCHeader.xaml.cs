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

namespace ContactAngleControl
{
    /// <summary>
    /// UCHeader.xaml 的交互逻辑
    /// </summary>
    public partial class UCHeader : UserControl
    {

        public Action<object, RoutedEventArgs> Click { get; set; }
        public UCHeader()
        {
            InitializeComponent();
        }

        public void SwitchMaxImg(bool IsFull)
        {
            if (IsFull)
            {
                this.Max.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("Img/max1.png", UriKind.Relative));
            }
            else {
                this.Max.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("Img/max.png", UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
                Click(sender, e);
        }
    }
}
