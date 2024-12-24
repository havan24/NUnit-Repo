using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class AutomateOrange
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

        [Test, Category("Sanity")]
        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //locators

            //ID
            driver.Manage().Window.Maximize();


            Thread.Sleep(3000);

            IWebElement UserName = driver.FindElement(By.XPath("//input[@placeholder='Username']"));

            UserName.SendKeys("Admin");

            Thread.Sleep(3000);

            IWebElement Password = driver.FindElement(By.XPath("//input[@placeholder='Password']"));

            Password.SendKeys("admin123");

            Thread.Sleep(3000);

            IWebElement Login = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));

            Login.Click();

            Thread.Sleep(3000);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }

    }
}
