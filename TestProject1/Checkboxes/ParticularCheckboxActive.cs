using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Basic_Selenium
{
    class ParticularCheckboxActive
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

            IWebElement student = driver.FindElement(By.Id("ctl00_mainContent_chk_StudentDiscount"));
            student.Click();


            if (student.Selected)
            {

                Console.WriteLine("Working Success");

            }
            else
            {

                Console.WriteLine("Working Unsuccess");

            }
            driver.Close();



        
       
   





        }
    }
}
