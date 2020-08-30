using ContactAngleControl.LogicCore.Interface;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ContactAngleControl.LogicCore.Base
{
    public class BaseViewDialog<TView> : IModelDialog where TView : new()
    {
        public TView Tview;

        /// <summary>
        /// 绑定数据上下文(主动)
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="viewModel"></param>
        public virtual void BindViewModel<T>(T viewModel)
        {
            var dialog = GetDialog();
            (dialog as UserControl).DataContext = viewModel;
        }

        /// <summary>
        /// 获取视图页
        /// </summary>
        /// <returns></returns>
        public virtual object GetDialog()
        {
            if (Tview == null)
            {
                Tview = new TView();
                this.RegisterDefaultEvent();
            }
            return Tview;
        }
        /// <summary>
        /// 弹出窗口
        /// </summary>
        /// <param name="openedEventHandler"></param>
        /// <param name="closingEventHandler"></param>
        /// <returns></returns>
        public virtual async Task<bool> ShowDialog(DialogOpenedEventHandler openedEventHandler = null, DialogClosingEventHandler closingEventHandler = null)
        {
            var dialog = GetDialog();
            object taskResult = await DialogHost.Show(dialog, "RootDialog", openedEventHandler, closingEventHandler); //位于顶级窗口
            if (taskResult != null)
            {
                if (taskResult is bool)
                {
                    return (bool)taskResult;
                }
            }
            return false;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        public virtual void Close() { }

        /// <summary>
        /// 注册窗口默认事件
        /// </summary>
        public virtual void RegisterDefaultEvent()
        {
        }

        public virtual void BindDefaultViewModel()
        {
        }
    }
}
