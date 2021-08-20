using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.WebTables
{
    class GetAllRowsAndColumns
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
        public void Rowsandcoulmns()
        {

            string part1 = "/html/body/div[6]/section[1]/div/section/div[1]/div/table/tbody/tr[";
            string part2 = "]/td[";
            string part3 = "]";

            for (int i = 1; i < 37; i++)
            {
                for (int j = 1; j < 9; j++)
                {

                    string value = driver.FindElement(By.XPath(part1 + i + part2 + j + part3)).Text;
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
