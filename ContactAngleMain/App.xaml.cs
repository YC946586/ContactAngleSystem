using ContactAngleControl.LogicCore.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ContactAngleMain
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            EventManager.RegisterClassHandler(typeof(TextBox), TextBox.GotFocusEvent, new RoutedEventHandler(TextBox_GotFocus));

            base.OnStartup(e);
            this.ConfigureServices();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
        /// <summary>
        /// 启动项注册
        /// </summary>
        protected void ConfigureServices()
        {
            AutofacLocator autofacLocator = new AutofacLocator();  //创建IOC容器
            autofacLocator.Register();   //注册服务
            BootStrapper.Initialize(autofacLocator);
        }
    }
}
