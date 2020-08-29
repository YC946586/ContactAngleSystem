using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleCommon
{
    public class ExcuteInfo<T> where T : new()
    {

        public static List<T> TableToList(DataTable dt)
        {
            List<T> list = new List<T>();//定义集合
            Type type = typeof(T);//获得此模型的类型           
            string TempName = string.Empty; //定义一个临时变量            
            foreach (DataRow dr in dt.Rows)//遍历Datatable中所有的数据行
            {
                T t = new T();
                PropertyInfo[] Propertys = t.GetType().GetProperties();//获得此模型的公共属性               
                foreach (PropertyInfo pi in Propertys) //遍历该对象的所有属性
                {
                    TempName = pi.Name; //将属性名称赋值给临时变量                    
                    if (dt.Columns.Contains(TempName))//检查DataTable是否包含此列（列名==对象的属性名）
                    {
                        //判断此属性是否有Setter
                        if (!pi.CanWrite) continue;//该属性不可写，直接跳出
                        //取值
                        object value = dr[TempName];
                        //如果非空，则赋给对象的属性
                        if (value != DBNull.Value)
                        {
                            //加一重if判断，如果属性值是int32类型的，就进行一次强制转换
                            string Name = pi.GetMethod.ReturnParameter.ParameterType.Name;
                            if (Name.Equals("Int32"))
                                value = Convert.ToInt32(value);

                            if (Name.Equals("Int64"))
                                value = Convert.ToInt64(value);
                            if (Name.Equals("Double"))
                                value = Convert.ToDouble(value);

                            pi.SetValue(t, value, null);
                        }
                    }
                }
                //对象添加到泛型集合中
                list.Add(t);
            }
            return list;
        }

    }
}
