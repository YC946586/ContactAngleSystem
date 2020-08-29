using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleUtils
{
    public class SQLiteHelper
    {
        //public static string connectionString = "Data Source = {0}DB\\ConfigDB.db; Password = hl0711RollingMonitoring;";
        public static string connectionString = "Data Source = {0}DB\\ConfigDB.db;";
        string root = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 数据库连接定义
        /// </summary>
        private SQLiteConnection connection;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">连接SQLite库字符串</param>
        public SQLiteHelper()
        {
            try
            {

                string dbPath = string.Format(connectionString, root);
                connection = new SQLiteConnection(dbPath);
                connection.Open();
            }
            catch (Exception e)
            {
                throw;
            }
        }


        /// <summary>
        /// 创建一个数据库文件。如果存在同名数据库文件，则会覆盖。
        /// </summary>
        /// <param name="dbName">数据库文件名。为null或空串时不创建。</param>
        public static void CreateDB(string dbName)
        {
            if (!string.IsNullOrEmpty(dbName))
            {
                try { SQLiteConnection.CreateFile(dbName); }
                catch (Exception) { throw; }
            }
        }

        /// <summary> 
        /// 对SQLite数据库执行增删改操作，返回受影响的行数。 
        /// </summary> 
        /// <param name="sql">要执行的增删改的SQL语句。</param> 
        /// <param name="parameters">执行增删改语句所需要的参数，参数必须以它们在SQL语句中的顺序为准。</param> 
        /// <returns></returns> 
        /// <exception cref="Exception"></exception>
        public int ExecuteNonQuery(string sql, params SQLiteParameter[] parameters)
        {
            int affectedRows = 0;

            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                try
                {
                    command.CommandText = sql;
                    if (parameters != null && parameters.Length != 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    affectedRows = command.ExecuteNonQuery();

                }
                catch (Exception) { throw; }

            }
            return affectedRows;
        }

        /// <summary>
        /// 批量处理数据操作语句。
        /// </summary>
        /// <param name="list">SQL语句集合。</param>
        /// <exception cref="Exception"></exception>
        public void ExecuteNonQueryBatch(List<KeyValuePair<string, SQLiteParameter[]>> list)
        {

            using (SQLiteTransaction tran = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    try
                    {
                        foreach (var item in list)
                        {
                            cmd.CommandText = item.Key;
                            if (item.Value != null)
                            {
                                cmd.Parameters.AddRange(item.Value);
                            }
                            cmd.ExecuteNonQuery();
                        }
                        tran.Commit();
                    }
                    catch (Exception) { tran.Rollback(); throw; }
                }
            }

        }

        /// <summary>
        /// 执行查询语句，并返回第一个结果。
        /// </summary>
        /// <param name="sql">查询语句。</param>
        /// <returns>查询结果。</returns>
        /// <exception cref="Exception"></exception>
        public object ExecuteScalar(string sql, params SQLiteParameter[] parameters)
        {

            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                try
                {

                    cmd.CommandText = sql;
                    if (parameters.Length != 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
                catch (Exception) { throw; }
            }
        }

        /// <summary> 
        /// 执行一个查询语句，返回一个包含查询结果的DataTable。 
        /// </summary> 
        /// <param name="sql">要执行的查询语句。</param> 
        /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准。</param> 
        /// <returns></returns> 
        /// <exception cref="Exception"></exception>
        public DataTable ExecuteQuery(string sql, params SQLiteParameter[] parameters)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                if (parameters != null && parameters.Length != 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable data = new DataTable();
                try { adapter.Fill(data); }
                catch (Exception e) { throw; }
                return data;
            }
        }

        /// <summary> 
        /// 执行一个查询语句，返回一个关联的SQLiteDataReader实例。 
        /// </summary> 
        /// <param name="sql">要执行的查询语句。</param> 
        /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准。</param> 
        /// <returns></returns> 
        /// <exception cref="Exception"></exception>
        public SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] parameters)
        {
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            try
            {
                if (parameters.Length != 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception) { throw; }
        }

        /// <summary> 
        /// 查询数据库中的所有数据类型信息。
        /// </summary> 
        /// <returns></returns> 
        /// <exception cref="Exception"></exception>
        public DataTable GetSchema()
        {
            try
            {
                return connection.GetSchema("TABLES");
            }
            catch (Exception) { throw; }
        }
    }
}
