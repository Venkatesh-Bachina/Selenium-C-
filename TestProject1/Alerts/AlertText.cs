using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Alerts
{
    class AlertText
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.tsrtconline.in/oprs-web/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Alerttext()
        {

            driver.FindElement(By.Id("searchBtn")).Click();
            string value = driver.SwitchTo().Alert().Text;
            Console.WriteLine(value);
            driver.SwitchTo().Alert().Accept(); ;

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
