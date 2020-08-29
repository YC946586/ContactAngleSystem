using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleCommon
{
    public class ExceptionHelper
    {
        public static T SafeInvoke<T>(Func<T> fun)
        {
            try
            {
                return fun();
            }
            catch (Exception e)
            {
                LogAPI.Debug(e.Message);
                return default(T);
            }
        }
    }
}
