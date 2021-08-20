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
    class EveryLinkName
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
            for (int i = 0; i < links.Count(); i++)
            {


                if (links.ElementAt(i).Displayed)
                {
                    string lname = links.ElementAt(i).Text;
                    links.ElementAt(i).Click();
                    string url = driver.Url;
                    Console.WriteLine(lname + "" + url);
                    driver.Navigate().Back();
                    links = driver.FindElements(By.TagName("a"));
                    Thread.Sleep(2000);





                }












            }
            driver.Quit();



        }
    }
}