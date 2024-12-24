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
    internal class RahulShettyTest
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

            //locators

            //ID
            driver.Manage().Window.Maximize();

            //Radio Buttons
            Thread.Sleep(2000);
            IWebElement Radio = driver.FindElement(By.XPath("(//input[@name='radioButton'])[3]"));
            if (Radio.Enabled) {
                Console.WriteLine("Radio Button is eanbled hence click on it");
                Radio.Click();
            }

            //Checkbox
            Thread.Sleep(2000);
            IWebElement Checkbox = driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));
            if (Checkbox.Displayed)
            {
                Console.WriteLine("Checkbox Button is displayed hence click on it");
                Checkbox.Click();
            }



        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
