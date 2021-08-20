using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.MouseHover
{
    class DoubleClick
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Doubleclick()
        {

            IWebElement Gsearch = driver.FindElement(By.Name("q"));
            OpenQA.Selenium.Interactions.Actions Ac = new OpenQA.Selenium.Interactions.Actions(driver);
            Ac.DoubleClick(Gsearch).Build().Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
