using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngle.Config
{
    public class SysAppPath
    {
        public static string SystemConfigName = "SystemConfig.xml";
        /// <summary>
        /// 获取当前程序的config目录。支持BS和CS的程序，都是获取到app\config\目录下
        /// </summary>
        /// <returns>返回路径字符串，末尾包括斜杠</returns>
        public static string GetConfigPath()
        {
            string strPath = GetCurrentAppPath();
            strPath += @"Configs\";
            return strPath;
        }
        /// <summary>
        /// 获取当前程序根目录，支持BS和CS的程序，都是获取到app目录下
        /// </summary>
        /// <returns>返回路径字符串，末尾包括斜杠</returns>
        public static string GetCurrentAppPath()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            if (!strPath.EndsWith(@"\"))
            {
                strPath += @"\";
            }

            return strPath;
        }

        public static string GetUpperPath()
        {
            string BasePath = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(Directory.GetParent(BasePath).FullName);
            BasePath = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(Directory.GetParent(BasePath).FullName);
            BasePath = Directory.GetCurrentDirectory();
            return BasePath;
        }

        public static void CopyDirectory(string srcPath, string destPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath); FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //获取目录下（不包含子目录）的文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)     //判断是否文件夹
                    {
                        if (!Directory.Exists(destPath + "\\" + i.Name))
                        {
                            Directory.CreateDirectory(destPath + "\\" + i.Name);   //目标目录下不存在此文件夹即创建子文件夹
                        }
                        CopyDirectory(i.FullName, destPath + "\\" + i.Name);    //递归调用复制子文件夹
                    }
                    else
                    {
                        File.Copy(i.FullName, destPath + "\\" + i.Name, true);      //不是文件夹即复制文件，true表示可以覆盖同名文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void DeleteDir(string file)
        {
            try
            {
                //去除文件夹和子文件的只读属性
                //去除文件夹的只读属性
                System.IO.DirectoryInfo fileInfo = new DirectoryInfo(file);
                fileInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

                //去除文件的只读属性
                System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal);

                //判断文件夹是否还存在
                if (Directory.Exists(file))
                {
                    foreach (string f in Directory.GetFileSystemEntries(file))
                    {
                        if (File.Exists(f))
                        {
                            //如果有子文件删除文件
                            File.Delete(f);
                            Console.WriteLine(f);
                        }
                        else
                        {
                            //循环递归删除子文件夹
                            DeleteDir(f);
                        }
                    }

                    //删除空文件夹
                    Directory.Delete(file);
                    Console.WriteLine(file);
                }

            }
            catch (Exception ex) // 异常处理
            {
                Console.WriteLine(ex.Message.ToString());// 异常信息
            }
        }
    }
}
