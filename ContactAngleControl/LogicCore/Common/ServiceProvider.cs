using ContactAngleControl.LogicCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.LogicCore.Common
{
    public class ServiceProvider
    {
        public static IAutoFacLocator Instance { get; private set; }

        public static void RegisterServiceLocator(IAutoFacLocator s)
        {
            Instance = s;
        }

    }
}
