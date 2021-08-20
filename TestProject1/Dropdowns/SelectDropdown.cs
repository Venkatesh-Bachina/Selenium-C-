using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Dropdowns
{
    class SelectDropdown
    {

        IWebDriver driver;

        

        

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.mercurytravels.co.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Selectdropdown()
        {

            //IWebElement holiday = driver.FindElement(By.Id("themes"));
            //holiday.SendKeys("family");

            IWebElement element = driver.FindElement(By.Id("themes"));
            SelectElement st = new SelectElement(element);
            st.SelectByIndex(4);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }


    }
}
