using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class ActionsClass
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

            IWebElement Prime = driver.FindElement(By.XPath("//a[@id='nav-link-amazonprime']"));
            Thread.Sleep(2000);

            new OpenQA.Selenium.Interactions.Actions(driver)
                .MoveToElement(Prime)
                .Click()
                .Perform();
            Thread.Sleep(2000);

        }

        [TearDown]

        public void closeBrowser()

        {
            driver.Close();
        }
    }
}
