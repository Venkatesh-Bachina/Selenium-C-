using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject1.Base;
using excel = Microsoft.Office.Interop.Excel;

namespace TestProject1.Pageobjects
{
    public class Steps : Base1
    {



        
            //public IWebDriver driver;

            [Test]
            public void TestMethod()
            {
                test = extent.CreateTest("login").Info("Test");



                driver = new ChromeDriver();
                test.Log(Status.Pass, "chromelaunched");
                driver.Url = "https://opensource-demo.orangehrmlive.com";
                test.Log(Status.Pass, "Urlpassed");

                driver.Manage().Window.Maximize();
                var page1 = new Hrmlogin(driver);



                excel.Application x = new excel.Application();
                excel.Workbook y = x.Workbooks.Open("C:\\excel\\Book1.xlsx");
                excel._Worksheet z = (excel._Worksheet)y.Sheets[1];
                excel.Range valuerange = z.UsedRange;
                int sw = valuerange.Rows.Count;
                for (int i = 2; i <= valuerange.Rows.Count; i++)
                {
                    // string Username = valuerange.Cells[i][1].value2;
                    string Username = Convert.ToString((valuerange.Cells[i, 1] as excel.Range).Value2);
                    string password = Convert.ToString((valuerange.Cells[i, 2] as excel.Range).Value2);
                    page1.login(Username, password);



                    Thread.Sleep(2000);
                }
                driver.Close();




            }
        }
    }










