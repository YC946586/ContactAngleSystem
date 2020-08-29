using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ContactAngleCommon;
using System.Text.RegularExpressions;

namespace ContactAngleUtils
{
    public class SqliteCommonHelper
    {
        private static Type Type;
        private static SQLiteHelper Sqlite = new SQLiteHelper();
        public static bool Insert<T>(T t)
        {
            Type = typeof(T);
            string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            string sql = "insert into {0}({1}) values({2})";
            StringBuilder FieldString = new StringBuilder();
            StringBuilder valueString = new StringBuilder();
            List<SQLiteParameter> sqlParameter = new List<SQLiteParameter>();
            SQLiteParameter sqlParam = null;
            PropertyInfo[] propertys = Type.GetProperties();// 获得此模型的公共属性
            foreach (PropertyInfo pi in propertys)
            {
                //string PrimaryKey = pi.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                if (!pi.Name.Equals("Id"))
                {
                    if (!pi.Ignore())
                    {
                        FieldString.Append(pi.Name + ",");
                        valueString.Append("@" + pi.Name + ",");
                        sqlParam = new SQLiteParameter("@" + pi.Name, pi.GetValue(t, null) ?? DBNull.Value);
                        sqlParameter.Add(sqlParam);
                    }
                }
            }
            sql = string.Format(sql, displayName, FieldString.ToString().Substring(0, FieldString.ToString().Length - 1), valueString.ToString().Substring(0, valueString.ToString().Length - 1));
            bool b = true;
            try
            {
                int QueryCount = Sqlite.ExecuteNonQuery(sql, sqlParameter.ToArray());
                if (QueryCount < 1)
                {
                    b = false;
                }
            }
            catch (Exception e)
            {
                b = false;
            }
            return b;

        }
        public static int Add<T>(T t)
        {
            Type = typeof(T);
            string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            string sql = "insert into {0}({1}) values({2});select last_insert_rowid() from {0}";
            StringBuilder FieldString = new StringBuilder();
            StringBuilder valueString = new StringBuilder();
            List<SQLiteParameter> sqlParameter = new List<SQLiteParameter>();
            SQLiteParameter sqlParam = null;
            PropertyInfo[] propertys = Type.GetProperties();// 获得此模型的公共属性
            foreach (PropertyInfo pi in propertys)
            {
                if (!pi.Name.Equals("Id"))
                {
                    if (!pi.Ignore())
                    {
                        FieldString.Append(pi.Name + ",");
                        valueString.Append("@" + pi.Name + ",");
                        sqlParam = new SQLiteParameter("@" + pi.Name, pi.GetValue(t, null) ?? DBNull.Value);
                        sqlParameter.Add(sqlParam);
                    }
                }
            }
            sql = string.Format(sql, displayName, FieldString.ToString().Substring(0, FieldString.ToString().Length - 1), valueString.ToString().Substring(0, valueString.ToString().Length - 1));
            try
            {
                DataTable dt = Sqlite.ExecuteQuery(sql, sqlParameter.ToArray());
                if (dt.Rows.Count <= 0)
                {
                    return -1;
                }
                else
                {
                    return Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception e)
            {
                return -1;
            }

        }
        public static int Delete<T>(string sqlWhere, object[] ParamsList = null)
        {
            try
            {
                Type = typeof(T);
                string DisplayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                StringBuilder Sqlsb = new StringBuilder();
                Sqlsb.Append("delete from " + DisplayName);
                if (!string.IsNullOrEmpty(sqlWhere))
                    Sqlsb.Append(" where ").Append(sqlWhere);
                List<SQLiteParameter> list = GetPara(Sqlsb.ToString(), ParamsList);
                return Sqlite.ExecuteNonQuery(Sqlsb.ToString(), list != null ? list.ToArray() : null);
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public static List<T> Get<T>(string sqlWhere, object[] ParamsList = null) where T : new()
        {
            try
            {
                Type = typeof(T);
                string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                StringBuilder Sqlsb = new StringBuilder();
                Sqlsb.Append("select * from ").Append(displayName);
                if (!string.IsNullOrEmpty(sqlWhere))
                    Sqlsb.Append(" where ").Append(sqlWhere);
                List<SQLiteParameter> list = GetPara(Sqlsb.ToString(), ParamsList);
                DataTable dt = Sqlite.ExecuteQuery(Sqlsb.ToString(), list != null ? list.ToArray() : null);
                return dt.Rows.Count > 0 ? ExcuteInfo<T>.TableToList(dt) : new List<T>();
            }
            catch (Exception e)
            {
                return new List<T>();
            }
        }
        public static List<T> GetAll<T>() where T : new()
        {
            return Get<T>("");
        }

        public static object ExecuteScalar(string sql)
        {
            return Sqlite.ExecuteScalar(sql);
        }

        public static int Update<T>(string sqlWhere, string strSet, object[] ParamsList = null)
        {
            try
            {
                Type = typeof(T);
                string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                StringBuilder Sqlsb = new StringBuilder();
                Sqlsb.Append("update " + displayName + " set ").Append(strSet);
                if (!string.IsNullOrEmpty(sqlWhere))
                    Sqlsb.Append(" where ").Append(sqlWhere);
                List<SQLiteParameter> list = GetPara(Sqlsb.ToString(), ParamsList);
                return Sqlite.ExecuteNonQuery(Sqlsb.ToString(), list != null ? list.ToArray() : null);
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public static bool Update<T>(T t)
        {
            Type = typeof(T);
            string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            string sql = "update {0} set {1} where {2}";
            StringBuilder SetString = new StringBuilder();
            StringBuilder WhereString = new StringBuilder();
            List<SQLiteParameter> sqlParameter = new List<SQLiteParameter>();
            SQLiteParameter sqlParam = null;
            PropertyInfo[] propertys = Type.GetProperties();// 获得此模型的公共属性
            foreach (PropertyInfo pi in propertys)
            {
                if (!pi.Name.Equals("Id"))
                {
                    if (!pi.Ignore())
                    {
                        SetString.Append(pi.Name + "=@" + pi.Name + ",");
                        sqlParam = new SQLiteParameter("@" + pi.Name, pi.GetValue(t, null) ?? DBNull.Value);
                        sqlParameter.Add(sqlParam);
                    }
                }
            }
            foreach (PropertyInfo pi in propertys)
            {
                if (pi.Name.Equals("Id"))
                {
                    if (!pi.Ignore())
                    {
                        WhereString.Append(pi.Name + "=@" + pi.Name);
                        sqlParam = new SQLiteParameter("@" + pi.Name, pi.GetValue(t, null) ?? DBNull.Value);
                        sqlParameter.Add(sqlParam);
                        break;
                    }
                }
            }
            sql = string.Format(sql, displayName,
                SetString.ToString().Substring(0, SetString.ToString().Length - 1),
                WhereString.ToString());
            bool b = true;
            try
            {
                int QueryCount = Sqlite.ExecuteNonQuery(sql, sqlParameter.ToArray());
                if (QueryCount < 1)
                {
                    b = false;
                }
            }
            catch (Exception e)
            {
                b = false;
            }
            return b;

        }
        public static bool InsertBatch<T>(List<T> t)
        {
            List<KeyValuePair<string, SQLiteParameter[]>> list = new List<KeyValuePair<string, SQLiteParameter[]>>();
            t.ForEach(x => { list.Add(GetSingleT<T>(x)); });
            bool b = true;
            try
            {
                Sqlite.ExecuteNonQueryBatch(list);
            }
            catch (Exception e)
            {
                b = false;
            }
            return b;
        }
        public static int ExecuteNonQuery(string sql, object[] ParamsList = null)
        {
            List<SQLiteParameter> list = GetPara(sql, ParamsList);
            return Sqlite.ExecuteNonQuery(sql, list != null ? list.ToArray() : null);
        }
        public static List<T> ExecuteQuery<T>(string sql, object[] ParamsList = null) where T : new()
        {
            List<SQLiteParameter> list = GetPara(sql, ParamsList);
            DataTable dt = Sqlite.ExecuteQuery(sql, list != null ? list.ToArray() : null);
            return dt.Rows.Count > 0 ? ExcuteInfo<T>.TableToList(dt) : new List<T>();
        }
        public static DataTable ExecuteDataTable(string sql, object[] ParamsList = null)
        {
            List<SQLiteParameter> list = GetPara(sql, ParamsList);
            DataTable dt = Sqlite.ExecuteQuery(sql, list != null ? list.ToArray() : null);
            return dt;
        }
        private static List<SQLiteParameter> GetPara(string sql, object[] ParamsList = null)
        {
            List<SQLiteParameter> list = new List<SQLiteParameter>();
            if (!string.IsNullOrEmpty(sql))
            {

                SQLiteParameter para = null;
                List<string> ParameterList = new List<string>();
                Regex reg = new Regex("(@[0-9a-zA-Z_]{1,30})", RegexOptions.IgnoreCase);
                MatchCollection mc = reg.Matches(sql);
                if (mc != null && mc.Count > 0)
                {
                    foreach (Match m in mc)
                    {
                        if (!ParameterList.Contains(m.Groups[1].Value))
                        {
                            ParameterList.Add(m.Groups[1].Value);
                        }
                    }
                }
                if (ParameterList.Count > 0)
                {
                    int i = 0;
                    foreach (string ParameterName in ParameterList)
                    {
                        para = new SQLiteParameter(ParameterName, ParamsList[i]);
                        list.Add(para);
                        i++;
                    }
                }
            }
            return list.Count > 0 ? list : null;
        }
        private static KeyValuePair<string, SQLiteParameter[]> GetSingleT<T>(T t)
        {
            Type = typeof(T);
            string displayName = Type.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            List<KeyValuePair<string, SQLiteParameter[]>> list = new List<KeyValuePair<string, SQLiteParameter[]>>();
            string sql = "insert into {0} ({1}) values({2})";
            StringBuilder FieldString = new StringBuilder();
            StringBuilder valueString = new StringBuilder();
            List<SQLiteParameter> sqlParameter = new List<SQLiteParameter>();
            SQLiteParameter sqlParam = null;
            PropertyInfo[] propertys = Type.GetProperties();// 获得此模型的公共属性
            foreach (PropertyInfo pi in propertys)
            {
                if (!pi.Name.Equals("Id"))
                {
                    if (!pi.Ignore())
                    {
                        FieldString.Append(pi.Name + ",");
                        valueString.Append("@" + pi.Name + ",");
                        sqlParam = new SQLiteParameter("@" + pi.Name, pi.GetValue(t, null) ?? DBNull.Value);
                        sqlParameter.Add(sqlParam);
                    }
                }
            }
            sql = string.Format(sql, displayName, FieldString.ToString().Substring(0, FieldString.ToString().Length - 1), valueString.ToString().Substring(0, valueString.ToString().Length - 1));
            return new KeyValuePair<string, SQLiteParameter[]>(sql, sqlParameter.Count > 0 ? sqlParameter.ToArray() : null);
        }
    }
}
