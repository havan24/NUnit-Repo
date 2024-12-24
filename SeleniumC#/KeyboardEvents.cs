using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class KeyboardEvents
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

            driver.Navigate().GoToUrl("https://www.facebook.com/");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement Email = driver.FindElement(By.Id("email"));
            IWebElement Password = driver.FindElement(By.Id("pass"));
            

            Thread.Sleep(1000);
            new Actions(driver)
                .MoveToElement(Email)
                .KeyDown(Keys.Shift)
                .SendKeys("rahul")
                .Perform();
            Password.Click();

         

            new Actions(driver)
                
                .KeyDown(Keys.Shift)
                .SendKeys("rahul1243l")
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
