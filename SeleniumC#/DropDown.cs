using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using TestProjectDecBatchEGIndia.Utilities;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class DropDown : Base
    {
    
        [Test]
        public void testcase1()

        {


            IWebElement Dropdown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(Dropdown);
            var select = new SelectElement(Dropdown);

            //select by visible Text
            //option1
            Thread.Sleep(2000);
            select.SelectByText("Option1");

            //select by index
            //option2
            Thread.Sleep(2000);
            select.SelectByIndex(2);

            //option3  by value
            Thread.Sleep(2000);
            select.SelectByValue("option3");
            Thread.Sleep(2000);

        }

    }
}
