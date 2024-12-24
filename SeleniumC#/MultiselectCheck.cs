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
    internal class MultiselectCheck
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()

        {
            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        [Test]
        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            //Checkbox
            Thread.Sleep(2000);
            // Thread.Sleep(2000);
            IReadOnlyList<IWebElement> chechbox = driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach (IWebElement element in chechbox)
            {
                // Console.WriteLine(element.Text);
                element.Click();
                Thread.Sleep(2000);

            }



        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
