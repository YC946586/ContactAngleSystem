using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ContactAngleCommon
{
    public class CtrlHelper
    {
        /// <summary>
        /// 寻找某一个组件下面的所有组件
        /// </summary>
        /// <typeparam name="ChildType"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<ChildType> FindVisualChild<ChildType>(DependencyObject obj) where ChildType : DependencyObject
        {
            List<ChildType> list = new List<ChildType>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is ChildType)
                {
                    list.Add(child as ChildType);
                }
            }
            return list;
        }
    }
}
