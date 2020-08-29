using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleCommon
{
    public class IgnoreAttribute : Attribute
    {
    }

    public static class IgnoreExtension
    {
        public static bool Ignore(this PropertyInfo pi)
        {
            if (pi.GetCustomAttribute<IgnoreAttribute>() == null)
                return false;
            return true;
        }
    }
}
