using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace YCCustomControl.Converters
{
    /// <summary>
    /// 显示转换器
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null)
            {
                switch (parameter.ToString())
                {
                    case "VisMsg":
                        {
                            if (value != null && bool.TryParse(value.ToString(), out bool dd))
                            {
                                if (dd)
                                    return Visibility.Visible;
                                else
                                    return Visibility.Collapsed;
                            }
                            return Visibility.Collapsed;
                        }
                   
                }
            }
            if (value != null && bool.TryParse(value.ToString(), out bool result))
            {
                if (!result)
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
