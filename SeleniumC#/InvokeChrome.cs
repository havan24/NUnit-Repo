using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class InvokeChrome
    {

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Launch your chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver

            driver = new FirefoxDriver();


        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
