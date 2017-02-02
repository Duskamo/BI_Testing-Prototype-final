using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Models
{
    class Results
    {
        public string TestDate { get; set; }
        public string TestCaseName { get; set; }
        public string SourceTableName { get; set; }
        public string TargetTableName { get; set; }
        public string TestCaseDescription { get; set; }
        public string Result { get; set; }
    }
}
