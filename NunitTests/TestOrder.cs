using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class TestOrder
    {
        [Test, Order(1)]
        public void reg()
        {
            Console.WriteLine("USer regidtration completed");
        }

        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("login");
        }

        [Test, Order(3)]
        public void product()
        {
            Console.WriteLine("Product");
        }

        [Test, Order(4)]
        public void order()
        {
            Console.WriteLine("Order");
        }
    }
}
