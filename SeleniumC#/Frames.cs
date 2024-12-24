using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class Frames
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

            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));
            Assert.IsNotNull(frame1);
            driver.SwitchTo().Frame(frame1);
            IWebElement newyork = driver.FindElement(By.XPath("//label[normalize-space()='New York']"));
            
            newyork.Click();
            Thread.Sleep(3000);
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
