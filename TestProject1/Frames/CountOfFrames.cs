using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Frames
{
    class CountOfFrames
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.automationtestinginsider.com/2019/08/textarea-textarea-element-defines-multi.html\"";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Countofframes()
        {

            IList<IWebElement> framecount = driver.FindElements(By.TagName("iframe"));
            Console.WriteLine("no of total frames : " + "" + framecount.Count);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
