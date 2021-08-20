using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.WebTables
{
    class GetDataFromAllColumnsAndRows
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
        public void Textfromcol()
        {

            string part1 = "/html/body/div[6]/section[1]/div/section/div[1]/div/table/tbody/tr[";
            string part2 = "]/td[1]";
            for (int i = 1; i <= 36; i++)
            {

                string value = driver.FindElement(By.XPath(part1 + i + part2)).Text;
                Console.WriteLine(value);
            }
        }

        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }

}
