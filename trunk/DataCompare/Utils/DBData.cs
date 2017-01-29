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
            new Table("Table1", new List<TableSchema>() {
                new TableSchema("id", "i"),
                new TableSchema("name", "s"),
                new TableSchema("age", "s"),
                new TableSchema("address", "s") },
                new string[,] { { "1","dustin","23","dope lane" }, { "2", "mary", "28", "pretty boss avenue" }, { "3", "sudeep", "25", "pimp blvd" }, { "4", "travis", "24", "thug street" }, { "5", "job", "27", "machine rd" } }),

            new Table("Table2", new List<TableSchema>() {
                new TableSchema("id", "i"),
                new TableSchema("name", "s"),
                new TableSchema("age", "s"),
                new TableSchema("address", "s") },
                new string[,] { { "1","dustin","23","dope lane" }, { "2", "mary", "28", "pretty boss avenue" }, { "3", "sudeep", "25", "pimp blvd" }, { "4", "travis", "24", "thug street" }, { "5", "job", "27", "machine rd" } }),

            new Table("Table3", new List<TableSchema>() {
                new TableSchema("id", "i"),
                new TableSchema("job title", "s"),
                new TableSchema("salary", "s"),
                new TableSchema("department", "s") },
                new string[,] { { "1","dustin","23","dope lane" }, { "2", "mary", "28", "pretty boss avenue" }, { "3", "sudeep", "25", "pimp blvd" }, { "4", "travis", "24", "thug street" }, { "5", "job", "27", "machine rd" } }),

            new Table("Table4", new List<TableSchema>() {
                new TableSchema("id", "i"),
                new TableSchema("name", "s"),
                new TableSchema("age", "s"),
                new TableSchema("address", "s") },
                new string[,] { { "1","dustin","23","dope lane" }, { "2", "mary", "28", "pretty boss avenue" }, { "3", "sudeep", "25", "pimp blvd" }, { "4", "travis", "24", "thug street" }, { "5", "job", "27", "machine rd" } }),

            new Table("Table5", new List<TableSchema>() {
                new TableSchema("id", "i"),
                new TableSchema("name", "s"),
                new TableSchema("age", "s"),
                new TableSchema("address", "s") },
                new string[,] { { "1","dustin","23","dope lane" }, { "2", "mary", "28", "pretty boss avenue" }, { "3", "sudeep", "25", "pimp blvd" }, { "4", "travis", "24", "thug street" }, { "5", "job", "27", "machine rd" } })
        };
    }
}
