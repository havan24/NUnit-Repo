using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class HekoruApp
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement Dropdown = driver.FindElement(By.Id("dropdown"));
            Assert.IsNotNull(Dropdown);
            var select = new SelectElement(Dropdown);

            //select by visible Text
            //option1
            Thread.Sleep(2000);
            select.SelectByText("Option 1");

            //select by index
            //option2
            Thread.Sleep(2000);
            select.SelectByIndex(2);

            //select by valve
            Thread.Sleep(2000);
            select.SelectByValue("1");
            Thread.Sleep(2000);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
