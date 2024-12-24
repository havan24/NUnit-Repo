using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void AssertionsEG() 
        {
            string actual = "google";
            string expected = "yahoo";

            if (actual == expected) {
                Console.WriteLine("The results are matching");
            }
            else
            {
                Console.WriteLine("The results are not matching");
            }

            //Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(actual, expected);
            //Assert.AreSame(actual, expected);
            Assert.AreNotSame(actual, expected);

            // Assert.That
            //Assert.That(actual, Is.EqualTo(expected));

            Assert.That(actual, Is.Not.EqualTo(expected));

            // Assert for string using ignore case
            //Assert.That(actual, Is.Not.EqualTo(expected).IgnoreCase);

            // Substring
            //Assert.That(actual, Does.Contain("goo").IgnoreCase);

            //empty assertions
            //Assert.IsTrue(actual.Equals(expected));

            //Assert.IsEmpty(actual);

            //Assert.IsNull(actual);

           // Assert.AreEqual(actual, expected);

            // Collection Constraints
            int[] array = new int[] { 1, 4, 8, 4, 5, 6, };
            Assert.NotNull(array);

            Assert.That(array, Is.All.GreaterThan(0));

           // Assert.IsEmpty(array);

            //Assert.That(array, Is.Ordered.Ascending);

            // Custom Exception

            int age = 17;

            //if(age < 18)
            //{
            //    throw new AssertionException("User is not eligible for voting");
            //}
        }
    }
}
