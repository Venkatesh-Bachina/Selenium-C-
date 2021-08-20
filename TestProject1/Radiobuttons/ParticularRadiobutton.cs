using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Radiobuttons
{
    class ParticularRadiobutton
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

            IWebElement Female = driver.FindElement(By.XPath("//*[@id='post-body-7514611991416825350']/div[1]/table/tbody/tr[6]/td[2]/input[2]"));
            Female.Click();

            if (Female.Selected)
            {

                Console.WriteLine("Working Success");

            }
            else
            {

                Console.WriteLine("Working Unsuccess");

            }


        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
