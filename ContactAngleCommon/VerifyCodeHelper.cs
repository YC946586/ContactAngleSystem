using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContactAngleCommon
{
    public class VerifyCodeHelper
    {
        public static Bitmap CreateVerifyCode(out string code)
        {
            //建立Bitmap对象，绘图
            Bitmap bitmap = new Bitmap(160, 60);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.FillRectangle(new SolidBrush(Color.White), 0, 0, 160, 60);
            Font font = new Font(FontFamily.GenericSerif, 48, System.Drawing.FontStyle.Bold, GraphicsUnit.Pixel);
            Random Ran = new Random();
            string Letters = "ABCDEFGHIJKLMNPQRSTUVWXYZ0123456789";

            StringBuilder sb = new StringBuilder();

            //添加随机的四个字母
            for (int x = 0; x < 4; x++)
            {
                string Letter = Letters.Substring(Ran.Next(0, Letters.Length - 1), 1);
                sb.Append(Letter);
                graph.DrawString(Letter, font, new SolidBrush(Color.Black), x * 38, Ran.Next(0, 15));
            }
            code = sb.ToString();

            //混淆背景
            Pen LinePen = new Pen(new SolidBrush(Color.Black), 2);
            for (int x = 0; x < 6; x++)
                graph.DrawLine(LinePen, new System.Drawing.Point(Ran.Next(0, 199), Ran.Next(0, 59)), new System.Drawing.Point(Ran.Next(0, 199), Ran.Next(0, 59)));
            return bitmap;
        }
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);

        /// <summary>
        /// 从bitmap转换成ImageSource  
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static System.Windows.Media.ImageSource ChangeBitmapToImageSource(Bitmap bitmap)
        {
            IntPtr hBitmap = bitmap.GetHbitmap();
            System.Windows.Media.ImageSource wpfBitmap = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(

                hBitmap,
                IntPtr.Zero,
                Int32Rect.Empty,
                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            if (!DeleteObject(hBitmap))
            {
                throw new System.ComponentModel.Win32Exception();
            }
            return wpfBitmap;

        }
    }
}
