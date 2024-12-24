using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    [Parallelizable(ParallelScope.All)]
    [Allure.NUnit.AllureNUnit]
    internal class BrowserCommands
    {

        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Launch your chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver

            driver = new FirefoxDriver();

            //get the title of the web page
            string title = driver.Title;
            Console.WriteLine(title);

            //get current url
            string currentURL = driver.Url;
            Console.WriteLine(currentURL);

            //get pagesource or html code
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);




        }
        [Test, Category("Regression")]
        public void testcase1()
        {
            // launch the application url
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        [TearDown]
        public void closebrowser()
        {
            driver.Close();

            //will close all the browser session
           // driver.Quit();
        }
    }
}
