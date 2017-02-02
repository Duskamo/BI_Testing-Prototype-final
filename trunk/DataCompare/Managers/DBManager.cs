
using DataCompare.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCompare.Enums;
using DataCompare.Models.Tables;

namespace DataCompare.Managers
{
    class DBManager
    {
        internal static DataTable RetrieveSourceDatabases()
        {
            return RetrieveDatabases(DBData.SourceDB);
        }

        internal static DataTable RetrieveTargetDatabases()
        {
            return RetrieveDatabases(DBData.TargetDB);
        }

        internal static DataTable RetrieveSourceTables()
        {
            return RetrieveTables("SourceDB");
        }

        internal static DataTable RetrieveTargetTables()
        {
            return RetrieveTables("TargetDB");
        }

        internal static DataTable RetrieveColumns(string comparingTableName, string tableName)
        {
            DataTable table = new DataTable(tableName);

            table.Columns.Add("NAME");

            foreach (Table t in DBData.dataset)
            {
                if (t.getName().Equals(comparingTableName))
                {
                    foreach(DataColumn col in t.getTable().Columns)
                    {
                        DataRow row = table.NewRow();
                        row["NAME"] = col.ColumnName + " [ " + col.DataType.ToString() + " ]";
                        table.Rows.Add(row);
                    }
                }
            }

            return table;
        }

        internal static DataTable UseSourceTable(DataTable currentTable, string value) 
        {
            return UseTables(currentTable,value);
        }

        internal static DataTable UseTargetTable(DataTable currentTable, string value)
        {
            return UseTables(currentTable, value);
        }

        private static DataTable UseTables(DataTable currentTable, string value)
        {
            DataRow row = currentTable.NewRow();
            row[0] = value;
            currentTable.Rows.Add(row);

            return currentTable;
        }

        // ****************** private  helpers ********************************
        private static DataTable RetrieveDatabases(string dbName)
        {
            var table = new DataTable();
            var column = new DataColumn("Name");
            table.Columns.Add(column);

            var row = table.NewRow();
            row[0] = dbName;
            table.Rows.Add(row);


            return table;
        }

        private static DataTable RetrieveTables(string tableName)
        {
            var table = new DataTable();
            var column = new DataColumn("Name");
            table.Columns.Add(column);

            foreach (var rowData in DBData.dataset)
            {
                var row = table.NewRow();
                row[0] = rowData.getName();
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
