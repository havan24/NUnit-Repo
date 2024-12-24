using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class Categories
    {
        [Test, Order(1), Category("Regression")]
        public void reg()
        {
            Console.WriteLine("USer regidtration completed");
        }

        [Test, Order(2), Category("Sanity")]
        public void login()
        {
            Console.WriteLine("login");
        }

        [Test, Order(3), Category("Regression")]
        public void product()
        {
            Console.WriteLine("Product");
        }

        [Test, Order(4), Category("Sanity")]
        public void order()
        {
            Console.WriteLine("Order");
        }
    }
}
