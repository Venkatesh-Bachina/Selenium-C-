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
    class AcutalTitle
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

            IWebElement title = driver.FindElement(By.LinkText("Gmail"));

            title.Click();



                string expected = "Gmail";
                string actual = driver.Title;
                Console.WriteLine(actual);


                if (expected.Contains(actual))
                {

                    Console.WriteLine("pass");

                }
                else
                {

                   Console.WriteLine("fail");

                }
               


                driver.Close();



            }

    }
}
