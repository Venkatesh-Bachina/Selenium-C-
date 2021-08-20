using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject1.WindowHandles
{
    class WindowHandles
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
            driver.Url = "http://demo.automationtesting.in/Windows.html";
            driver.Manage().Window.Maximize();
            IWebElement tabeedWindow = driver.FindElement(By.XPath("//*[@id=\"Tabbed\"]/a/button"));
            tabeedWindow.Click();
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Console.WriteLine(" Current window handle title : " + driver.Title);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(" Current window handle title : " + driver.Title);





            Thread.Sleep(2000);


            driver.Quit();






        }
    }







}













   







