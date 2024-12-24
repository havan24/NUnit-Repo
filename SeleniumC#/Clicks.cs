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
    internal class Clicks
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

            //locators

            //ID
            driver.Manage().Window.Maximize();

           IWebElement RightClick = driver.FindElement(By.LinkText("Best Sellers"));
            Thread.Sleep(2000);
            IWebElement ContextClick = driver.FindElement(By.XPath("//a[@href='/deals?ref_=nav_cs_gb']"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .ContextClick(ContextClick)  
                .Pause(TimeSpan.FromSeconds(5))
                .DoubleClick(RightClick)
                .Pause(TimeSpan.FromSeconds(5))
                .Perform();
        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
