using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCompare.Managers;
using DataCompare.Enums;

namespace DataCompare.UnitTest.Managers
{
    [TestClass]
    public class TestSqlManager
    {
        [TestMethod]
        public void GetConnectionStringTest()
        {
            string server = ".";
            string user = "sa";
            string pwd = "test";
            string db = "Employee";
            string host = "127.0.0.1";
            string port = "8080";

            string except1 = String.Format("server={0};Integrated Security=SSPI;", server);
            string except2 = String.Format("server={0};Integrated Security=SSPI;database={1}", server, db);
            string except3 = String.Format("server={0};user id={1};pwd={2};", server, user, pwd);
            string except4 = String.Format("server={0};user id={1};pwd={2};database={3}", server, user, pwd, db);
            string except5 = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SID={2})));User Id={3};Password={4}", host, port, db, user, pwd);

            Assert.AreEqual(except1, SqlManager.GetConnectionString(server, true, user, pwd, String.Empty, DatabaseType.SqlServer));
            Assert.AreEqual(except2, SqlManager.GetConnectionString(server, true, user, pwd, db, DatabaseType.SqlServer));
            Assert.AreEqual(except3, SqlManager.GetConnectionString(server, false, user, pwd, String.Empty, DatabaseType.SqlServer));
            Assert.AreEqual(except4, SqlManager.GetConnectionString(server, false, user, pwd, db, DatabaseType.SqlServer));
            Assert.AreEqual(except5, SqlManager.GetConnectionString(host + ":" + port, true, user, pwd, db, DatabaseType.Oracle));
            Assert.AreEqual(except5, SqlManager.GetConnectionString(host + ":" + port, false, user, pwd, db, DatabaseType.Oracle));
        }

        [TestMethod]
        public void GetRetrieveDatabasesStringTest()
        {
            string except1 = "SELECT Name FROM Master..SysDatabases ORDER BY Name";
            string except2 = "";

            Assert.AreEqual(except1, SqlManager.GetRetrieveDatabasesString(DatabaseType.SqlServer));
            Assert.AreEqual(except2, SqlManager.GetRetrieveDatabasesString(DatabaseType.Oracle));
        }

        [TestMethod]
        public void GetRetrieveTablesStringTest()
        {
            string except1 = "SELECT u.name + '.' + o.name as Name FROM SysObjects o, SysUsers u Where o.uid = u.uid AND o.XType IN ('U','V') ORDER BY o.XType,o.Name";
            string except2 = "SELECT TABLE_NAME AS NAME FROM USER_TABLES UNION SELECT VIEW_NAME AS NAME FROM USER_VIEWS ORDER BY NAME";

            Assert.AreEqual(except1, SqlManager.GetRetrieveTablesString(DatabaseType.SqlServer));
            Assert.AreEqual(except2, SqlManager.GetRetrieveTablesString(DatabaseType.Oracle));
        }

        [TestMethod]
        public void GetRetrieveColumnsStringTest()
        {
            string tableName = "test";

            string except1 = "SELECT c.name + ' [' + t.name + '(' + cast(c.length as varchar) + ')]' AS NAME FROM SysColumns c, SysTypes t  WHERE c.xusertype = t.xusertype AND c.id = OBJECT_ID('{0}')";
            string except2 = "SELECT COLUMN_NAME||' ['||DATA_TYPE||'('||DATA_LENGTH||')]' AS NAME FROM user_tab_columns WHERE table_name='{0}'";
            except1 = String.Format(except1, tableName);
            except2 = String.Format(except2, tableName);

            Assert.AreEqual(except1, SqlManager.GetRetrieveColumnsString(DatabaseType.SqlServer, tableName));
            Assert.AreEqual(except2, SqlManager.GetRetrieveColumnsString(DatabaseType.Oracle, tableName));
        }

        [TestMethod]
        public void GetSelectStringTest()
        {
            string cols = "id, name";
            string table = "test";
            string filter = "id=3";
            string order = "name";
            string sql = "SELECT {0} FROM {1} WHERE {2} ORDER BY {3}";

            string except1 = String.Format(sql, cols, table, filter, order);
            string except2 = String.Format(sql, cols, table, "1=1", order);

            Assert.AreEqual(except1, SqlManager.GetSelectString(cols, table, filter, order));
            Assert.AreEqual(except2, SqlManager.GetSelectString(cols, table, String.Empty, order));
        }

        [TestMethod]
        public void GetRowCountStringTest()
        {
            string table = "test";
            string filter = "id=1";
            string sql = "SELECT COUNT(1) FROM {0} WHERE {1}";

            string except1 = String.Format(sql, table, filter);
            string except2 = String.Format(sql, table, "1=1");

            Assert.AreEqual(except1, SqlManager.GetRowCountString(table, filter));
            Assert.AreEqual(except2, SqlManager.GetRowCountString(table, String.Empty));
        }
    }
}
