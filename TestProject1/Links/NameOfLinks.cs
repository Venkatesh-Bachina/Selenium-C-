using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Basic_Selenium
{
    class NameOfLinks
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
            driver.Url = "https://www.google.com/";


            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            Console.WriteLine("no of total links" + "" + links.Count());


            for (int i = 0; i < links.Count(); i++)
            {
                Console.WriteLine(links.ElementAt(i).Text);
            }

            driver.Close();

        }  
    }


}
