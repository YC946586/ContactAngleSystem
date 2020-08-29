using ContactAngleModel.ViewModel;
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
    /// UCFooter.xaml 的交互逻辑
    /// </summary>
    public partial class UCFooter : UserControl
    {

        private UCFooterViewModel ViewModel { get; set; }
        public UCFooter()
        {
            InitializeComponent();
            this.Loaded += UCFooter_Loaded;
        }

        private void UCFooter_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel = new UCFooterViewModel() {
                HardwareStatus = "上线",
                RunningStatus = TryFindResource("HardwareStatus1") as string,
                VideoCurrentFrame = 1,
                AllFrame = 48
            };
            this.DataContext = ViewModel;
        }

        public void UpdateStatus(UCFooterViewModel db)
        {
            ViewModel.HardwareStatus = db.HardwareStatus;
            ViewModel.RunningStatus = db.RunningStatus;
            ViewModel.VideoCurrentFrame = db.VideoCurrentFrame;
            ViewModel.AllFrame = db.AllFrame;
        }
    }
}
