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
    class StatusOfCheckbox
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

            IList<IWebElement> Statusofcheckbox = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            Console.WriteLine("no of total Statusofcheckbox " + "" + Statusofcheckbox.Count);

            for (int i = 0; i < Statusofcheckbox.Count; i++)
            {
                string rname = Statusofcheckbox.ElementAt(i).GetAttribute("name");

                if (Statusofcheckbox.ElementAt(i).Selected)
                {

                    Console.WriteLine(rname  + "" +  "Active");

                }

                else
                {

                    Console.WriteLine(rname + "" + "DeActive");
                }
            }

            driver.Close();







        }
    }
}
