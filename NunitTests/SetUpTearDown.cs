using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class SetUpTearDown
    {
        [SetUp]
        public void launchBrowser()
        {
            Console.WriteLine("Launching the browser");
        }

        [SetUp]
        public void dbConnection()
        {
            Console.WriteLine("Connecting database");
        }

        [TearDown]
        public void closeBrowser()
        {
            Console.WriteLine("Closing the browser");
        }


        [Test, Order(1)]
        public void reg()
        {
            Console.WriteLine("User regidtration completed");
        }

        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("user login");
        }

        [Test, Order(3)]
        public void product()
        {
            Console.WriteLine("Product done");
        }


    }
}
