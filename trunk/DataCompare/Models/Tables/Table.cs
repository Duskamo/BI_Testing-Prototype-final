using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models.Tables
{
    class Table
    {
        private string _Name;
        private DataTable table;

        public Table(string name, List<TableInfo> schema)
        {
            setName(name);
            setSchema(schema);
            table = new DataTable();
        }

        private void setSchema(List<TableInfo> schema)
        {
            // add column names and type to the table
            for (int i = 0; i < schema.Count; i++)
            {
                System.Type type = findType(schema[i].getType());
                table.Columns.Add(schema[i].getName(),type);
            }

            // add row data to the table
            for (int i = 0; i < schema.Count; i++)
            {
                DataRow row = table.NewRow();
                /*
                for (int j = 0; j < )
                {
                    row[0] = schema[i].getData();
                }
                */
                table.Rows.Add(row);
            }
        }

        private System.Type findType(string stringType)
        {
            System.Type type = null;

            switch (stringType)
            {
                case "s":
                    type = typeof(System.String);
                    break;
                case "i":
                    type = typeof(int);
                    break;
            }

            return type;
        }

        // ********* getters/setters ************
        public string getName()
        {
            return _Name;
        }

        public void setName(string name)
        {
            _Name = name;
        }
    }
}
