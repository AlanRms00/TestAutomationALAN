using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestAutomationALAN.PageObject3;

namespace TestAutomationALAN.TestCase

{
    [TestFixture]
    public class Test3
    {

        public IWebDriver driver;


        [SetUp]

        public void BeforeTest()
        {
            driver = new ChromeDriver(@"C:\Users\alanp\Downloads\chromedriver_win32 (2)");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(" https://www.testfaceclub.com/aut-vuelos/");
        }




        [Test]

        public void BtnSearch()
        {
            try
            {
                driver.SwitchTo().DefaultContent();
 
                VuelosAUTpage vuelosAutPage = new VuelosAUTpage(driver);

                vuelosAutPage.BuscarViajeBtn();
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}

