using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCompare.Utils.Sql;
using System.Data;
using System.Xml;
using System.Data.Common;

namespace DataCompare.UnitTest.Utils.Sql
{
    [TestClass]
    public class TestSqlServerUtil
    {
        SqlServerUtil ssu;

        public TestSqlServerUtil()
        {
            string conn = "server=.;Integrated Security=SSPI;database=EmployeeManagement";
            this.ssu = new SqlServerUtil(conn);
            this.ssu.Open();
        }

        [TestMethod]
        public void ExecuteSQLTest()
        {
            string sql = "SELECT * FROM [EmployeeManagement].[dbo].[employee] WHERE 1=2";
            int excepted = 8;

            DataTable result = ssu.ExecuteSQL(sql);
            int actual = result.Columns.Count;

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void ExecuteSQLWithTableNameTest()
        {
            string sql = "SELECT * FROM [EmployeeManagement].[dbo].[employee] WHERE 1=2";
            int exceptedCount = 8;
            string exceptedName = "test";

            DataTable result = ssu.ExecuteSQL(sql, exceptedName);
            int actualCount = result.Columns.Count;
            string actualName = result.TableName;

            Assert.AreEqual(exceptedCount, actualCount);
            Assert.AreEqual(exceptedName, actualName);
        }

        [TestMethod]
        public void GetDataAdapterTest()
        {
            string sql = "SELECT * FROM [EmployeeManagement].[dbo].[employee] WHERE 1=2";

            DbDataAdapter dda = ssu.GetDataAdapter(sql);

            Assert.AreEqual(sql, dda.SelectCommand.CommandText);
        }

        [TestMethod]
        public void GetDataReaderTest()
        {
            string sql = "SELECT * FROM [EmployeeManagement].[dbo].[employee] WHERE id=1";

            DbDataReader ddr = ssu.GetDataReader(sql);

            Assert.AreEqual(true, ddr.HasRows);
        }
    }
}
