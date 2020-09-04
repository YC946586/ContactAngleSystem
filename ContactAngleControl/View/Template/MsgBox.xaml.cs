using ContactAngleControl.LogicCore.Interface;
using MaterialDesignThemes.Wpf;
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

namespace ContactAngleControl.View.Template
{
    /// <summary>
    /// MsgBox.xaml 的交互逻辑
    /// </summary>
    public partial class MsgBox : UserControl
    {
        public MsgBox()
        {
            InitializeComponent();
        }
    }
    /// <summary>
    /// 弹窗
    /// </summary>
    public class MsgDlg : IShowContent
    {
        private UserControl view;

        public void BindDataContext<T, V>(T control, V viewModel)
            where T : UserControl
            where V : class, new()
        {
            view = control;
            view.DataContext = viewModel;
        }

        public void BindDataContext<V>(V viewModel) where V : class, new()
        {
            view.DataContext = viewModel;
        }

        public async Task<bool> Show()
        {
            if (view == null) return false;
            object taskResult = await DialogHost.Show(view, "RootDialog"); //位于顶级窗口
            if (taskResult!=null)
            {
                return (bool)taskResult;
            }
            return false;

        }
    }
}
