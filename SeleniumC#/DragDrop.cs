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
    internal class DragDrop
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement Source = driver.FindElement(By.Id("column-a"));
            Thread.Sleep(2000);
            IWebElement dest = driver.FindElement(By.Id("column-b"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .DragAndDrop(Source, dest)
                .Perform();
            Thread.Sleep(2000);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
