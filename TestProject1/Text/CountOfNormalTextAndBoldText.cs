using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Text
{
    class CountOfNormalTextAndBoldText
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/newtours/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Countofnormalandboldtext()
        {

            IList<IWebElement> ntext = driver.FindElements(By.TagName("P"));
            Console.WriteLine("no of total normal text  : " + "" + ntext.Count);
            IList<IWebElement> btext = driver.FindElements(By.TagName("B"));
            Console.WriteLine("no of total bold text : " + "" + btext.Count);

        }

        [Test]
        public void VerifyNtextandBtext()
        {

            IWebElement text = driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[1]/td/font/b"));
            string expected = "b";
            string actual = text.TagName;
            if (expected.Equals(actual))
            {
                Console.WriteLine("BoldText");
            }

        }



       [OneTimeTearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
