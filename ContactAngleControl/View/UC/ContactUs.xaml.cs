﻿using ContactAngleControl.LogicCore.Base;
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
    /// ContactUs.xaml 的交互逻辑
    /// </summary>
    public partial class ContactUs : UserControl
    {
        public ContactUs()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// 液态控制设置
    /// </summary>
    [Autofac(true)]
    public class ContactUsDlg : BaseViewDialog<ContactUs>, IModelDialog
    {

    }
}
