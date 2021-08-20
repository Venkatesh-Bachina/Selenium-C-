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
    class NameOfCheckboxes
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
            driver.Url = "https://www.spicejet.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            IList<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            Console.WriteLine("no of total radios" + "" + checkboxes.Count);


            for (int i = 0; i < checkboxes.Count; i++)
            {

                Console.WriteLine(checkboxes.ElementAt(i).GetAttribute("name"));

            }
            driver.Close();


        }
    }

}
