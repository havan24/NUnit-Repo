using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.DataDrivenTesting
{
    internal class TestParameterUnsingTestCase
    {
        [TestCase(1,2,3)]
        [TestCase(12, 2, 6)]
        [TestCase(4,5,6)]
        public void TetsSum(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }
    }
}
