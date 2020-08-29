using ContactAngle.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactAngleCommon
{
    public class LogAPI
    {
        private static readonly string LOG_DIR = "日志";
        private static readonly string LOG_FILE = LOG_DIR + "\\log" + System.DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        //private const string LOG4NET_CONFIG = "log4net_config.xml";
        private static readonly log4net.ILog m_log = log4net.LogManager.GetLogger(typeof(LogAPI));

        /// <summary>
        /// 静态构造函数
        /// </summary>


        static LogAPI()
        {
            try
            {
                Configure();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 返回ILog接口
        /// </summary>
        private static log4net.ILog Log
        {
            get { return m_log; }
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="sInfo"></param>
        public static void Debug(string sInfo)
        {
            m_log.Error(sInfo);
        }


        /// <summary>
        /// 记录debug信息，需要在服务 bin 中 加入 log4net_config.xml，生成的日志在 bin-日志
        /// </summary>
        /// <param name="e"></param>
        public static void Debug(Exception e)
        {
            Debug("Message : " + e.Message);
            Debug("Source : " + e.Source);
            Debug("StackTrace : " + e.StackTrace);
            Debug("TargetSite : " + e.TargetSite);
            if (e.InnerException != null)
            {
                Debug(e.InnerException);
            }
        }

        /// <summary>
        /// 配置log4net环境
        /// </summary>
        private static void Configure()
        {
            //XmlDocument doc = new XmlDocument();
            string sPath = GetAssemblyPath();

            if (!sPath.EndsWith("\\"))
            {
                sPath += "\\";
            }
            //查看Log文件夹是否存在，如果不存在，则创建
            string sLogDir = sPath + LOG_DIR;
            if (!Directory.Exists(sLogDir))
            {
                Directory.CreateDirectory(sLogDir);
            }
            string sLogFile = sPath + LOG_FILE;
            //sPath += LOG4NET_CONFIG;
            //doc.Load(@sPath);

            XmlElement myElement = ToXmlElement(SysConfigsOprator.GetxElementByConfig("log4net"));
            if (myElement == null) return;
            //修改log.txt的路径
            XmlNode pLogFileAppenderNode = myElement.SelectSingleNode("descendant::appender[@name='LogFileAppender']/file");
            XmlAttributeCollection attrColl = pLogFileAppenderNode.Attributes;
            attrColl[0].Value = sLogFile;

            log4net.Config.XmlConfigurator.Configure(myElement);
        }

        /// <summary>
        /// 获取Assembly的运行路径 \\结束
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyPath()
        {
            string sCodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            sCodeBase = sCodeBase.Substring(8, sCodeBase.Length - 8);    // 8是 file:// 的长度
            string[] arrSection = sCodeBase.Split(new char[] { '/' });
            string sDirPath = "";
            for (int i = 0; i < arrSection.Length - 1; i++)
            {
                sDirPath += arrSection[i] + Path.DirectorySeparatorChar;
            }
            return sDirPath;
        }


        #region XElement与XmlElement的转换

        /// <summary>
        /// XElement转换为XmlElement
        /// </summary>
        public static XmlElement ToXmlElement(XElement xElement)
        {
            if (xElement == null) return null;

            XmlElement xmlElement = null;
            XmlReader xmlReader = null;
            try
            {
                xmlReader = xElement.CreateReader();
                var doc = new XmlDocument();
                xmlElement = doc.ReadNode(xmlReader) as XmlElement;
            }
            catch
            {
            }
            finally
            {
                if (xmlReader != null) xmlReader.Close();
            }

            return xmlElement;
        }

        /// <summary>
        /// XmlElement转换为XElement
        /// </summary>
        public static XElement ToXElement(XmlElement xmlElement)
        {
            if (xmlElement == null) return null;

            XElement xElement = null;
            try
            {
                var doc = new XmlDocument();
                doc.AppendChild(doc.ImportNode(xmlElement, true));
                xElement = XElement.Parse(doc.InnerXml);
            }
            catch { }

            return xElement;
        }

        #endregion

    }
}
