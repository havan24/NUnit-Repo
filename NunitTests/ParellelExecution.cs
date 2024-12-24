using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParellelExecution
    {

        [Test]
        public void reg()
        {
            Console.WriteLine("USer regidtration completed");
        }

        [Test]
        public void login()
        {
            Console.WriteLine("login");
        }

        [Test]
        public void product()
        {
            Console.WriteLine("Product");
        }

        [Test]
        public void order()
        {
            Console.WriteLine("Order");
        }
    }
}
