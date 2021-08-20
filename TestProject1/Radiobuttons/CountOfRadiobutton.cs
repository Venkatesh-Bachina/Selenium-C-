using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Radiobuttons
{
    class CountOfRadiobutton
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
            Console.WriteLine("no of total radiobuttons : " + "" + radiobuttons.Count);
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }
}
