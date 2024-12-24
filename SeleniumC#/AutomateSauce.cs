using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class AutomateSauce
    {

        IWebDriver driver;
        [SetUp]
        public void startBrowser()

        {
            //launch edge browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web drive
            driver = new EdgeDriver();

        }

        [Test, Category("Sanity")]
        public void testSauce()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");

            //locator
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");
            Thread.Sleep(1000);

            Thread.Sleep(1000);
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(1000);
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();

            Thread.Sleep(1000);
            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product_label']"));

            //Display Validation
            if (Products.Displayed)
            {
                Console.WriteLine("User is in Home page");
            }
            else {
                Console.WriteLine("User is not on the home page");
            }


            //Using assertion class
            string actualText = Products.Text;
            string expectedValue = "Products";
            Assert.AreEqual(actualText, expectedValue);
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }

    }
}
