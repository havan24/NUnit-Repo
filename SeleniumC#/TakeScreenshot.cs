using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class TakeScreenshot
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();


            Screenshot ss = driver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\hakul\\Downloads\\db.drawio.png");

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
