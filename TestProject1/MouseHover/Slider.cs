using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.MouseHover
{
    class Slider
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/slider/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void slider()
        {

            Actions ac = new Actions(driver);
            driver.SwitchTo().Frame(0);

            IWebElement slider = driver.FindElement(By.Id("slider"));
            int widthslider = slider.Size.Width;

            Actions Ac = new Actions(driver);
            Ac.ClickAndHold(slider);
            Ac.MoveByOffset(  70, 80  ).Build().Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }
    }
}
