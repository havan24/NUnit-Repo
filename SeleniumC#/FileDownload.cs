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
    internal class FileDownload
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




            IWebElement Download = driver.FindElement(By.XPath("//a[normalize-space()='SomeFile.txt']"));
            Download.Click();
            Thread.Sleep(3000);

            if (File.Exists("C:\\Users\\hakul\\Downloads\\SomeFile.txt"))
            {
                Console.WriteLine("File downloaded");
            }
            else
            {
                Console.WriteLine("Not Downloaded");
            }


        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
        }
}
