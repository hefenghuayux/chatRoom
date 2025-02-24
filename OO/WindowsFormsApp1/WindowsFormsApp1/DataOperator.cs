using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DataOperator
    {
        private static string connectString = @"Server=hefeng;Database=oodata;User=remote_user;Password=134679";
        public static SqlConnection connection = new SqlConnection(connectString);

        //返回查询结果中的第一行第一列
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);   //指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)         //如果当前数据库连接处于关闭状态
                connection.Open();                                  //打开数据库连接
            int num = Convert.ToInt32(command.ExecuteScalar());     //执行查询
            connection.Close();                                 //关闭数据库连接
            return num;                                         //返回结果中的第一行第一列
        }
        //返回结果返回行数
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);   //指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)         //如果当前数据库连接处于关闭状态
                connection.Open();                                  //打开数据库连接
            int result = command.ExecuteNonQuery();             //执行SQL语句
            connection.Close();                                 //关闭数据库连接
            return result;                                      //返回受影响的行数
        }
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection); //指定要执行的SQL语句
            DataSet ds = new DataSet();                             //创建数据集对象
            sqlda.Fill(ds);                                         //填充数据集
            return ds;                                              //返回数据集
        }
        public DataSet GetDataSet(string sql, SqlParameter[] parameters)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            if (parameters != null)
            {
                sqlda.SelectCommand.Parameters.AddRange(parameters);
            }
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }

    }
}
