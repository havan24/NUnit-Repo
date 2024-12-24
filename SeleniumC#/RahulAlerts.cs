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
    internal class RahulAlerts
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            Thread.Sleep(2000);


            //Handling Informational Alerts
            IWebElement InformationalAlert = driver.FindElement(By.XPath("//input[@id='alertbtn']"));
            InformationalAlert.Click();
            IAlert alt = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            //clicking OK button
            alt.Accept();
            Thread.Sleep(2000);

            //Handling Confirmational Alerts
            IWebElement ConfirmationalAlert = driver.FindElement(By.XPath("//input[@id='confirmbtn']"));
            ConfirmationalAlert.Click();
            Thread.Sleep(3000);
            //clicking cancel button
            alt.Dismiss();
            Thread.Sleep(2000);




        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
