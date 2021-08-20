using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Basic_Selenium
{
    class HeaderLinks
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.in/";

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            IWebElement header = driver.FindElement(By.Id("gb"));

            IList<IWebElement> headerlinks = header.FindElements(By.TagName("a"));


            for (int i = 0; i < headerlinks.Count(); i++)
            {

                //TestContext.WriteLine(headerlinks.ElementAt(i).Text);
                Console.WriteLine(headerlinks.ElementAt(i).Text);
            }

            driver.Quit();


        }
    }
}

