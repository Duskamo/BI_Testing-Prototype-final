using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models
{
    class TestCaseInfo
    {
        public static string RowCountTestName(string tableName)
        {
            return tableName + " row count validation";
        }

        public static string RowCountTestDescription()
        {
            return "Validate the row count is valid from source to target.";
        }

        public static string SchemaTestName(string tableName)
        {
            return tableName + " schema validation";
        }

        public static string SchemaTestDescription()
        {
            return "Validate the table schema is equal from source to target.";
        }

        public static string EqualityTestName(string tableName)
        {
            return tableName + " data equality validation";
        }

        public static string EqualityTestDescription()
        {
            return "Validate the data is equal from source to target.";
        }
    }
}
