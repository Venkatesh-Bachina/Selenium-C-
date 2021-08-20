using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Alerts
{
    class AlertSendkeys
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/alertsdemo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }
        [Test]
        public void Alertsendkeys()
        {
            driver.FindElement(By.Id("promptBox")).Click();
            IAlert promptAlert = driver.SwitchTo().Alert();
            Console.WriteLine(promptAlert.Text);
            promptAlert.SendKeys("Alert");
            Thread.Sleep(1000);
            promptAlert.Accept();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
            Thread.Sleep(1000);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }

    }
}
