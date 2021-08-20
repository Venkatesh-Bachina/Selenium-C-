using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Frames
{
    class SwitchToFrame
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

            IList<IWebElement> iframeList = driver.FindElements(By.TagName("iframe"));
            int totalFrames = iframeList.Count;
            Console.WriteLine("No of Frames:" + totalFrames);
            IWebElement ele = driver.FindElement(By.Name("iframe_b"));
            Console.WriteLine("Frame Names are:");

            foreach(IWebElement iframe in iframeList )
              {
                Console.WriteLine(iframe.GetAttribute("name"));
                if (iframe.GetAttribute("name").Equals("iframe_b"))
                {

                    driver.SwitchTo().Frame(ele);                 //switch to frame by element

                    //Perform all the required tasks 

                    driver.FindElement(By.Id("searchInput")).SendKeys("iframe Testing");
                    Thread.Sleep(2000);

                    driver.SwitchTo().DefaultContent();               //Switching back to the main window



                }
            }

            Boolean btnDisplayed = driver.FindElement(By.Id("simpleAlert")).Displayed;
            Console.WriteLine(btnDisplayed);
        }
    }
}
