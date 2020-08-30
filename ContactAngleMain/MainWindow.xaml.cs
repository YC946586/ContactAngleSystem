using ContactAngleCommon;
using ContactAngleModel.ExtendModel;
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

namespace ContactAngleMain
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsFull = true;
        private double W, H;
        private double MinW = 1600, MinH = 865;


        public MainWindow()
        {
            InitializeComponent();
            W = SystemParameters.WorkArea.Width;
            H = SystemParameters.WorkArea.Height;
            InitWnd(new MainSize(0, 0, W, H));//初始化窗体
            SwitchLanguage();//初始化语言
            this.Loaded += MainWindow_Loaded;
        }

        private void InitWnd(MainSize size)
        {
            this.Left = size.Left;
            this.Top = size.Top;
            this.Width = size.Width;
            this.Height = size.Height;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.UCHeader.Click = Button_Click;
            this.UCMenu.SwitchLanguage = SwitchLanguage;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Index = Convert.ToInt32((sender as Button).Tag.ToString());
            switch (Index)
            {
                case 1: break;
                case 2:
                    this.WindowState = WindowState.Minimized;
                    break;
                case 3:
                    SwitchFull();
                    break;
                case 4:
                    this.Close();
                    break;
                default: break;
            }
        }

        private void SwitchFull()
        {
            if (IsFull)
            {
                InitWnd(new MainSize((W - MinW) / 2, (H - MinH) / 2, MinW, MinH));
                IsFull = false;
            }
            else
            {
                InitWnd(new MainSize(0, 0, W, H));
                IsFull = true;
            }
            this.UCHeader.SwitchMaxImg(IsFull);
        }
        private void SwitchLanguage(int index)
        {
            Properties.Settings.Default.DefaultLanguage = index;
            Properties.Settings.Default.Save();
            ReStart();
        }
        private void SwitchLanguage()
        {
            int DefaultLanguage = Properties.Settings.Default.DefaultLanguage;
            string LangName = "SimplifiedChinese";
            switch (DefaultLanguage)
            {
                case 0:
                    LangName = "SimplifiedChinese";
                    break;
                case 1:
                    LangName = "TraditionalChinese";
                    break;
                case 2:
                    LangName = "English";
                    break;
                default: break;
            }
            ResourceDictionary langRd = null;
            try
            {
                //根据名字载入语言文件
                langRd = Application.LoadComponent(new Uri(@"Language\" + LangName + ".xaml", UriKind.Relative)) as ResourceDictionary;
            }
            catch (Exception e)
            {
                LogAPI.Debug(e.Message);
            }

            if (langRd != null)
            {
                //如果已使用其他语言,先清空
                if (this.Resources.MergedDictionaries.Count > 0)
                {
                    this.Resources.MergedDictionaries.Clear();
                }
                this.Resources.MergedDictionaries.Add(langRd);
            }

        }

        private void UCHeader_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SwitchFull();
        }

   
        private void UCHeader_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }

            }
            catch (Exception)
            {

            }
        }

        private void ReStart()
        {
            System.Reflection.Assembly.GetEntryAssembly();
            string startpath = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(startpath + "\\ContactAngleMain.exe");
            Application.Current.Shutdown();
        }
       
    }
}
