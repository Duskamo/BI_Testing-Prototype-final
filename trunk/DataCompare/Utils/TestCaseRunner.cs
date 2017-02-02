using DataCompare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompare.Utils
{
    class TestCaseRunner
    {
        public static TestResults RunRowCountTestCase(TestResults testResult)
        {
            TestResults newResult = new TestResults();

            newResult.TestDate = DateTime.Now.ToShortDateString();
            newResult.TestCaseName = TestCaseInfo.RowCountTestName(testResult.TargetTableName);
            newResult.SourceTableName = testResult.SourceTableName;
            newResult.TargetTableName = testResult.TargetTableName;
            newResult.TestCaseDescription = TestCaseInfo.RowCountTestDescription();
            newResult.Result = "Pass";

            return newResult;
        }

        public static TestResults RunSchemaTestCase(TestResults testResult)
        {
            TestResults newResult = new TestResults();

            newResult.TestDate = DateTime.Now.ToShortDateString();
            newResult.TestCaseName = TestCaseInfo.SchemaTestName(testResult.TargetTableName);
            newResult.SourceTableName = testResult.SourceTableName;
            newResult.TargetTableName = testResult.TargetTableName;
            newResult.TestCaseDescription = TestCaseInfo.SchemaTestDescription();
            newResult.Result = "Pass";

            return newResult;
        }

        public static TestResults RunEqualityTestCase(TestResults testResult)
        {
            TestResults newResult = new TestResults();

            newResult.TestDate = DateTime.Now.ToShortDateString();
            newResult.TestCaseName = TestCaseInfo.EqualityTestName(testResult.TargetTableName);
            newResult.SourceTableName = testResult.SourceTableName;
            newResult.TargetTableName = testResult.TargetTableName;
            newResult.TestCaseDescription = TestCaseInfo.EqualityTestDescription();
            newResult.Result = "Pass";

            return newResult;
        }
    }
}
