using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.WebTables
{
    class DataFromParticularRowAndColumn
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
        public void Counttables()
        {

            string value1 = driver.FindElement(By.XPath("/html/body/div[6]/section[1]/div/section/div[1]/div/table/tbody/tr[2]/td[7]/a")).Text;
            Console.WriteLine(value1);
            string value2 = driver.FindElement(By.XPath("/html/body/div[6]/section[1]/div/section/div[1]/div/table/tbody/tr[1]/td[3]/a")).Text;
            Console.WriteLine(value2);

        }

        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
