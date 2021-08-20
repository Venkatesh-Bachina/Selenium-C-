using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;


namespace TestProject1.Excel
{
    class ExcelData
    {

        [Test]
        public void TestMethod1()
        {
            excel.Application x = new excel.Application();
            excel.Workbook y = x.Workbooks.Open("C:\\excel\\Book1.xlsx");
            excel._Worksheet z = (excel._Worksheet)y.Sheets[1];
            excel.Range valuerange = z.UsedRange;
            int sw = valuerange.Rows.Count;

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Window.Maximize();
            for (int i = 2; i <= valuerange.Rows.Count; i++)
            {
                // string Username = valuerange.Cells[i][1].value2;
                string Username = Convert.ToString((valuerange.Cells[i, 1] as excel.Range).Value2);
                string password = Convert.ToString((valuerange.Cells[i, 2] as excel.Range).Value2);
                //string password = Convert.ToString((valuerange.Cells[i, 2] as excel.Range).Value2);
                driver.FindElement(By.Id("txtUsername")).SendKeys(Username);
                driver.FindElement(By.Id("txtPassword")).SendKeys(password);
                driver.FindElement(By.Id("btnLogin")).Click();
                Thread.Sleep(1000);

            }
        }
    }
}

