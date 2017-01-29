using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models
{
    class TableSchema
    {
        private string _Name;
        private string _Type;

        public TableSchema(string colName, string colType)
        {
            setName(colName);
            setType(colType);
        }

        public void setType(string colType)
        {
            _Type = colType;
        }

        public void setName(string colName)
        {
            _Name = colName;
        }

        public string getName()
        {
            return _Name;
        }

        public string getType()
        {
            return _Type;
        }
    }
}
