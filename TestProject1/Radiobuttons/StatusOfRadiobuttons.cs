using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Radiobuttons
{
    class StatusOfRadiobuttons
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
            driver.Url = "https://www.automationtestinginsider.com/2019/08/student-registration-form.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            IList<IWebElement> radiobuttons = driver.FindElements(By.XPath("//input[@type='radio']"));
            Console.WriteLine("no of totalradiobuttons" + "" + radiobuttons.Count);

            for (int i = 0; i < radiobuttons.Count; i++)
            {

                string rname = radiobuttons.ElementAt(i).GetAttribute("name");

                if (radiobuttons.ElementAt(i).Selected)
                {
                    Console.WriteLine(rname  +  ""  +  "Active");
                }

                else
                {
                    Console.WriteLine(rname  +  ""  +  "DeActive");
                }

            }

        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
