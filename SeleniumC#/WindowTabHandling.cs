using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class WindowTabHandling
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2); //Global Weight

            //fetch the parent window hnadle
            string parentHandle = driver.CurrentWindowHandle;
            IWebElement ClickHere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => ClickHere.Displayed);
            ClickHere.Click();
            Thread.Sleep(2000);
            
            //fetch the window handle of all the windows - two windows are opended
            IList<string> windowHandles = new List<string>(driver.WindowHandles);

            // Move the control to the child window
            driver.SwitchTo().Window(windowHandles[1]);

            string title = driver.Title;
            Console.WriteLine(title);
            Thread.Sleep(2000);


            //Assert.AreEqual("New Window", title);
            driver.Close();

            driver.SwitchTo().Window(windowHandles[0]);
            string parentTitle = driver.Title;
            Console.WriteLine(parentTitle);
            Thread.Sleep(2000);

            // Assert.AreEqual("The Internet", title);
            //driver.Close();

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
