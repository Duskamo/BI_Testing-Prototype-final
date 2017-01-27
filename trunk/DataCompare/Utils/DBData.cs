using DataCompare.Models;
using DataCompare.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Utils
{
    class DBData
    {
        public static string SourceDB = "SourceDB";
        public static string TargetDB = "TargetDB";

        public static List<Table> dataset = new List<Table>() {
            new Table("Table1", new List<TableInfo>() { new TableInfo("id", "i", new List<string>() { "1", "2", "3", "4", "5" }) }),
            new Table("Table2", new List<TableInfo>() { new TableInfo("id", "i", new List<string>() { "1", "2", "3", "4", "5" }) }),
            new Table("Table3", new List<TableInfo>() { new TableInfo("id", "i", new List<string>() { "1", "2", "3", "4", "5" }) }),
            new Table("Table4", new List<TableInfo>() { new TableInfo("id", "i", new List<string>() { "1", "2", "3", "4", "5" }) }),
            new Table("Table5", new List<TableInfo>() { new TableInfo("id", "i", new List<string>() { "1", "2", "3", "4", "5" }) })
        };
    }
}
