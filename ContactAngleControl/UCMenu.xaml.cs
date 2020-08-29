﻿using ContactAngleCommon;
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
    /// UCMenu.xaml 的交互逻辑
    /// </summary>
    public partial class UCMenu : UserControl
    {
        public Action<int> SwitchLanguage;
        public UCMenu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int Index = Convert.ToInt32((sender as MenuItem).Tag.ToString());
            SwitchLanguage?.Invoke(Index);
        }
    }
}
