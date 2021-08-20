using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.WebTables
{
    class CountOfTables
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.timeanddate.com/worldclock/";


            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Test1()
        {
            IList<IWebElement> tablesCount = driver.FindElements(By.TagName("table"));
            Console.WriteLine("no of total tablesCount" + "" + tablesCount.Count);
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }


    }
 }

