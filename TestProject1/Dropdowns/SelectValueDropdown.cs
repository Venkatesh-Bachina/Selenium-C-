using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Dropdowns
{
    class SelectValueDropdown
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
        public void Selectvaluedropdown()
        {

            IWebElement holiday = driver.FindElement(By.Id("themes"));
            IList<IWebElement> values = holiday.FindElements(By.TagName("option"));
            Console.WriteLine("no of total values" + "" + values.Count);
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values.ElementAt(i).Text);

            }

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
