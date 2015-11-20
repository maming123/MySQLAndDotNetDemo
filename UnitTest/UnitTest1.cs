using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using MySQLDemo;
using Util;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            DemoCls.GetUserRole();
        }
        [TestMethod]
        public void TestMethod1()
        {
            ExecuteDataTableTest();
        }
        private static void ExecuteDataTableTest()
        {

            string sql = "select * from city";
            DataTable dt = MySQLHelper.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.Write("{0}:{1}\t", dc.ColumnName, dr[dc.ColumnName].ToString());
                }
            }
        }

        private static void InsertTest()
        {
            string sql = "insert into user(Id,Name) values(?Id,?Name);";
            MySqlParameter[] spArr = new MySqlParameter[]{
                new MySqlParameter("Id",2),
                new MySqlParameter("Name","leaf")
            };
            int r = MySQLHelper.ExecuteNonQuery(sql, spArr);
        }

        private static void TestConnection()
        {
            //测试连接是否正常
            using (MySqlConnection conn = MySQLHelper.GetConnection)
            {
                try
                {
                    conn.Open();
                    //Console.WriteLine("打开 My SQL 连接成功！");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("打开 MySQL 连接失败，错误原因：" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
