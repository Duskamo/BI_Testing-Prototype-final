using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models.Tables
{
    class Table
    {
        private string _Name;
        private DataTable _Table;
        private string[,] _Data;

        public Table(string name, List<TableSchema> schema, string[,] data)
        {
            setName(name);
            setTable(new DataTable());
            setData(data);
            loadSchema(schema);
            loadData();
        }

        private void loadSchema(List<TableSchema> schema) 
        {
            // add column names and type to the table
            for (int i = 0; i < schema.Count; i++)
            {
                System.Type type = findType(schema[i].getType());
                _Table.Columns.Add(schema[i].getName(),type);
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

        private void loadData()
        {
            // add row data to the table
            for (int i = 0; i < _Data.GetLength(0); i++)
            {
                DataRow row = _Table.NewRow();

                for (int j = 0; j < _Data.GetLength(1); j++)
                {
                    row[j] = _Data[i,j];
                }

                _Table.Rows.Add(row);
            }
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

        public void setTable(DataTable table)
        {
            this._Table = table;
        }

        public DataTable getTable()
        {
            return _Table;
        }

        public void setData(string[,] data)
        {
            this._Data = data;
        }

        public string[,] getData()
        {
            return _Data;
        }
    }
}
