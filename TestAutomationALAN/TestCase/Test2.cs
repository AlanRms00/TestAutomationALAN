using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationALAN.PageObject;

namespace TestAutomationALAN.TestCase
{
    [TestFixture]
    public class Test2
    {
        protected IWebDriver    Driver;
        protected IWebDriver driver;

        
        [SetUp]

        public void before2()
        {
            
            driver = new ChromeDriver(@"C:\Users\alanp\Downloads\chromedriver_win32");
            driver.Manage().Window.Maximize();
        }



        public void Login(IWebDriver driver)
        {
            
            driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");
            LoginAut loginAut = new LoginAut(driver);
            Employee employee = loginAut.LoginAs("Alan", "1234");

            
        }
       
      [Test]
        public void EnterInfoForm()
        {
            try { 
            Login(driver);
            Employee employee = new Employee(driver);
            Thread.Sleep(3000);
            employee.EnterInfo("Alan","aaa@gmail.com","AV. LAS VILLAS ","129739012");
                driver.SwitchTo().Alert();
                employee.CloseAlert();
            }

            catch (Exception ex) {  
           Console.WriteLine(ex.Message);
            }
        }
    
    }
}
