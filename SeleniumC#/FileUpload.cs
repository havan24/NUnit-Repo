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
    internal class FileUpload
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

            IWebElement Browser = driver.FindElement(By.Id("file-upload"));
            Browser.SendKeys("C:\\Users\\hakul\\Documents\\db.drawio");

            IWebElement Upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));

            Upload.Click();

            Thread.Sleep(3000);
        }

        [TearDown]

        public void closeBrowser()

        {
            driver.Close();
        }
    }
}
