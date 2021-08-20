using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.MouseHover
{
    class MoveToElement
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
        public void Movetoelement()
        {

            OpenQA.Selenium.Interactions.Actions ac = new OpenQA.Selenium.Interactions.Actions(driver);
            IWebElement link = driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul/li[10]/a"));
            ac.MoveToElement(link).Build().Perform();
            Thread.Sleep(2000);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
