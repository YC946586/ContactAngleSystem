using ContactAngleControl.LogicCore.Base;
using ContactAngleControl.LogicCore.Common;
using ContactAngleControl.LogicCore.Interface;
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

namespace ContactAngleControl.View.UC
{
    /// <summary>
    /// 表面能 的交互逻辑
    /// </summary>
    public partial class SurfaceEnergy : UserControl
    {
        public SurfaceEnergy()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// 表面能
    /// </summary>
    [Autofac(true)]
    public class SurfaceEnergyDlg : BaseViewDialog<SurfaceEnergy>, IModelDialog
    {

    }
}
