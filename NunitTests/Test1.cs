using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Test1
    {
        [Test, Description("FirstTest Case Description")]
        public void test1()
        {
            Console.WriteLine("First test case is executed.");
        }
    }
}
