using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TestProjectDecBatchEGIndia.SeleniumC_;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.Utilities
{
    public class Base
    {


        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();

        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    // launch firefox browser
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    DropDown obj = new DropDown();
                    break;

                case "Chrome":
                    // launch chrome browser
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    // launch Edge browser
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        [TearDown]
        public void TearDownBrowser() 
        {
            if (driver != null) 
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}
