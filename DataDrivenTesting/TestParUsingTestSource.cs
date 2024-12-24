using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.DataDrivenTesting
{
    internal class TestParUsingTestSource
    {


        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " : " + password);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "1111");
            yield return new TestCaseData("efg.com", "2222");
            yield return new TestCaseData("hij.com", "3333");
            yield return new TestCaseData("lmn.com", "4444");

        }
    }
}
