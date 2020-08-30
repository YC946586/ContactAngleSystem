using ContactAngleControl.LogicCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.LogicCore.Common
{
    public class BootStrapper
    {
        /// <summary>
        /// 注册方法
        /// </summary>
        public static void Initialize(IAutoFacLocator autoFacLocator)
        {
            ServiceProvider.RegisterServiceLocator(autoFacLocator);
            ServiceProvider.Instance.Register();
        }
    }
}
