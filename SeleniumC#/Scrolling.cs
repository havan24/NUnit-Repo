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
    internal class Scrolling
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

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();


            IWebElement amazonScience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .ScrollToElement(amazonScience)
                .Click(amazonScience)
                .Perform();

            Thread.Sleep(5000);


        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
