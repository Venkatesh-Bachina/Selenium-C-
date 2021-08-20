using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading;

namespace TestProject1.Config_Files
{
    public class Tests
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
            //driver = new ChromeDriver();
            driver.Url = "https://sampleregistration.z35.web.core.windows.net/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement Name = driver.FindElement(By.Id("n"));
            var name = ConfigurationManager.AppSettings["name"];
            Name.SendKeys(name);
            IWebElement mail = driver.FindElement(By.Id("m"));
            var Mail = ConfigurationManager.AppSettings["mail"];
            mail.SendKeys(Mail);
            IWebElement phone = driver.FindElement(By.Id("ph"));
            var ph = ConfigurationManager.AppSettings["ph"];
            phone.SendKeys(ph);
            IWebElement check = driver.FindElement(By.Id("flexCheckDefault"));
            check.Click();
            IWebElement reg = driver.FindElement(By.XPath("/html/body/app-root/form/button"));
            reg.Click();
            Thread.Sleep(2000);
            driver.Close();
            //Assert.Pass();
        }
    }

}

