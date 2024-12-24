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
    internal class SwagLabsAutomation
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()

        {
            //launch edge browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web drive
            driver = new EdgeDriver();

        }

        [Test]
        public void testSauce()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");

            //locator
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");
            Thread.Sleep(1000);

            Thread.Sleep(1000);
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(1000);
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();

            Thread.Sleep(1000);

            IWebElement AddToCart = driver.FindElement(By.XPath("//div[@class='inventory_list']//div[1]//div[3]//button[1]"));
            AddToCart.Click();
            Thread.Sleep(1000);

            IWebElement Cart = driver.FindElement(By.XPath("//*[name()='path' and contains(@fill,'currentCol')]"));
            Cart.Click();
            Thread.Sleep(1000);

            IWebElement CartItem = driver.FindElement(By.LinkText("Sauce Labs Backpack"));
            Assert.AreEqual(CartItem.Text, "Sauce Labs Backpack");
            Thread.Sleep(1000);


            IWebElement Quantity = driver.FindElement(By.XPath("//div[@class='cart_quantity']"));
            Assert.AreEqual(Quantity.Text, "1");
            Thread.Sleep(1000);

            IWebElement CheckOut = driver.FindElement(By.XPath("//a[normalize-space()='CHECKOUT']"));
            CheckOut.Click();
            Thread.Sleep(1000);

           
            IWebElement Firstname = driver.FindElement(By.Id("first-name"));
            Firstname.SendKeys("Ravi");
            Thread.Sleep(1000);

            IWebElement Lastname = driver.FindElement(By.Id("last-name"));
            Lastname.SendKeys("Gupta");
            Thread.Sleep(1000);

            IWebElement PostalCode = driver.FindElement(By.Id("postal-code"));
            PostalCode.SendKeys("123456");
            Thread.Sleep(1000);

            IWebElement Continue = driver.FindElement(By.XPath("//input[@value='CONTINUE']"));
            Continue.Click();
            Thread.Sleep(1000);

            IWebElement Finish = driver.FindElement(By.XPath("//a[normalize-space()='FINISH']"));
            Finish.Click();
            Thread.Sleep(1000);

            IWebElement Done = driver.FindElement(By.XPath("//h2[normalize-space()='THANK YOU FOR YOUR ORDER']"));
            Assert.AreEqual(Done.Text, "THANK YOU FOR YOUR ORDER");
            Thread.Sleep(2000);
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
