using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactAngle.Config
{
    public class SysConfigsOprator
    {
        public static XElement GetxElementByConfig(string elementName)
        {
            XDocument pXDoc = XDocument.Load(SysAppPath.GetConfigPath() + SysAppPath.SystemConfigName);
            if (pXDoc == null || string.IsNullOrWhiteSpace(elementName)) return null;
            return pXDoc.Element("configuration").Descendants(elementName).FirstOrDefault();
        }
    }
}
