using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class NavigationalCommands
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //Launch your chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //initialize the web driver

            driver = new ChromeDriver();

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
        [Test]
        public void testcase1()
        {
            // launch the application url
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            // Maximize
            Thread.Sleep(3000);
            driver.Manage().Window.Maximize();


            //navigate Back
            Thread.Sleep(3000);
            driver.Navigate().Back();


            //Navigate forward
            Thread.Sleep(3000);
            driver.Navigate().Forward();


            //Refresh
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            


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
