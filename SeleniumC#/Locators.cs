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
    internal class Locators
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
        [Test]
        public void testcase1()
        {
            // launch the application url
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");

            //locators
            //Id
            Thread.Sleep(2000);
            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
            FirstName.SendKeys("Havan");

            //name
            Thread.Sleep(2000);
            IWebElement LastName = driver.FindElement(By.XPath("//input[@name='lastname']"));
            LastName.SendKeys("Kotian");

            //Xpath
            Thread.Sleep(2000);
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id = 'username']"));
            UserName.SendKeys("HavanKotian24");

            //xpath
            Thread.Sleep(2000);
            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("1234");

            //Link Text
            //Thread.Sleep(2000);
            //IWebElement BackToLogin = driver.FindElement(By.LinkText("Back to Login"));
            //BackToLogin.Click();

            //Partial Link Text
            Thread.Sleep(2000);
            IWebElement Register = driver.FindElement(By.PartialLinkText("Back to Log"));
            Register.Click();


            //css selector
            //Thread.Sleep(2000);
            //IWebElement Element = driver.FindElement(By.CssSelector("button[class='accordion-button']"));
            //Element.Click();

            //tag name 
            //Thread.Sleep(2000);
            //IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
            //input.Click();

            //tag name 
            //Thread.Sleep(2000);
            //IWebElement classname = driver.FindElement(By.ClassName("(//input[@class = 'form-control'])[1]"));
            //classname.SendKeys("abc");
            //Thread.Sleep(2000);


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
