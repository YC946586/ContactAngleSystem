using ContactAngleControl.LogicCore.Common;
using ContactAngleControl.LogicCore.Interface;
using ContactAngleControl.View.Win;
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
    /// UCToolBar.xaml 的交互逻辑
    /// </summary>
    public partial class UCToolBar : UserControl
    {
        public UCToolBar()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var retuest = (sender as Button).Tag + "Dlg";
                var dialog = ServiceProvider.Instance.Get<IModelDialog>(retuest);
                dialog.BindDefaultViewModel();
                bool taskResult = await dialog.ShowDialog();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TestQueryPageView view = new TestQueryPageView();
            view.Show();
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _ = Msg.Question("Test");
        }
    }
}
