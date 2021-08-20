using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.Frames
{
    class TextOfFrames
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
        public void Textofframes()
        {

            IList<IWebElement> frameText = driver.FindElements(By.TagName("iframe"));
            Console.WriteLine("no of total framestext : " + "" + frameText.Count);
            for (int i = 0; i < frameText.Count ; i++)
            {
                Console.WriteLine(frameText.ElementAt(i).GetAttribute("name"));
            }

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
