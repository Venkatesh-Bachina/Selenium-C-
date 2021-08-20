using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Alerts
{
    class AlertConfirmation
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
        public void Alertconfirmation()
        {

            driver.FindElement(By.Id("confirmBox")).Click();
            IAlert confirmationAlert = driver.SwitchTo().Alert();
            Console.WriteLine(confirmationAlert.Text);
            Thread.Sleep(1000);
            confirmationAlert.Accept();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
            Thread.Sleep(1000);

        }

        [Test]
        public void Alertconfirmationcancel()
        {

            driver.FindElement(By.Id("confirmBox")).Click();
            IAlert confirmationAlert = driver.SwitchTo().Alert();
            Console.WriteLine(confirmationAlert.Text);
            Thread.Sleep(1000);
            confirmationAlert.Dismiss();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
            Thread.Sleep(1000);

        }


        [OneTimeTearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
