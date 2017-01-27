using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models
{
    class TableInfo
    {
        private string _Name;
        private string _Type;
        private List<string> _Data;

        public TableInfo(string colName, string colType, List<string> data)
        {
            setName(colName);
            setType(colType);
            setData(data);
        }

        private void setData(List<string> data)
        {
            _Data = data;
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

        public List<string> getData()
        {
            return _Data;
        }
    }
}
