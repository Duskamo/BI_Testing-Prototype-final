using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCompare.Utils.Sql;
using System.Data.Common;
using System.Data;

namespace DataCompare.UnitTest.Utils.Sql
{
    [TestClass]
    public class TestOracleUtil
    {
        OracleUtil ou;

        public TestOracleUtil()
        {
            string conn = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.2.1.188)(PORT=1521))(CONNECT_DATA=(SID=orcl)));User Id=amyhu;Password=amyhu";
            this.ou = new OracleUtil(conn);
            this.ou.Open();
        }

        [TestMethod]
        public void ExecuteSQLTest()
        {
            string sql = "SELECT * FROM EMPLOYEE WHERE 1=2";
            int excepted = 8;

            DataTable result = ou.ExecuteSQL(sql);
            int actual = result.Columns.Count;

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void ExecuteSQLWithTableNameTest()
        {
            string sql = "SELECT * FROM EMPLOYEE WHERE 1=2";
            int exceptedCount = 8;
            string exceptedName = "test";

            DataTable result = ou.ExecuteSQL(sql, exceptedName);
            int actualCount = result.Columns.Count;
            string actualName = result.TableName;

            Assert.AreEqual(exceptedCount, actualCount);
            Assert.AreEqual(exceptedName, actualName);
        }

        [TestMethod]
        public void GetDataAdapterTest()
        {
            string sql = "SELECT * FROM EMPLOYEE WHERE 1=2";

            DbDataAdapter dda = ou.GetDataAdapter(sql);

            Assert.AreEqual(sql, dda.SelectCommand.CommandText);
        }

        [TestMethod]
        public void GetDataReaderTest()
        {
            string sql = "SELECT * FROM EMPLOYEE WHERE id=1";

            DbDataReader ddr = ou.GetDataReader(sql);

            Assert.AreEqual(true, ddr.HasRows);
        }
    }
}
