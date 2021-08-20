using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.MouseHover
{
    class DragAndDrop
    {

        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/droppable/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [Test]
        public void Draganddrop()
        {

            OpenQA.Selenium.Interactions.Actions AC = new OpenQA.Selenium.Interactions.Actions(driver);
           
                driver.SwitchTo().Frame(0);

                IWebElement drag = driver.FindElement(By.Id("draggable"));
                IWebElement drop = driver.FindElement(By.Id("droppable"));

            AC.DragAndDrop(drag, drop).Build().Perform();

            Thread.Sleep(1000);

        }
        [TearDown]
        public void Quit()
        {
            driver.Close();
        }



    }
}
