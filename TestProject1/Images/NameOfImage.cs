using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Images
{
    class NameOfImage
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
            driver.Url = "https://www.flipkart.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            IList<IWebElement> images = driver.FindElements(By.TagName("img"));
            for (int i = 0; i < images.Count; i++)
            {
                
                Console.WriteLine(images.ElementAt(i).GetAttribute("src"));
            }


        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}

