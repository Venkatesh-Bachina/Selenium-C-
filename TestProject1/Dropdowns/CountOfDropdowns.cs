using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Dropdowns
{
    class CountOfDropdowns
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
        public void Dropdowncount()
        {

            IList<IWebElement> dropdowns = driver.FindElements(By.TagName("select"));
            Console.WriteLine("no of total dropdowns : "  + "" + dropdowns.Count);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
