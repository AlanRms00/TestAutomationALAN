using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestAutomationALAN.PageObject;

namespace TestAutomationALAN.TestCase
{
    //Clase de test para Login
    [TestFixture]//Anotacion para que Nunit Detecte los test
    public class Test1
    {
        protected IWebDriver driver;


        [SetUp]

        public void BeforTest()
        {
            driver = new ChromeDriver(@"C:\Users\alanp\Downloads\chromedriver_win32 (1)\chromedriver_win32 (2)");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");
        }
        [Test]//Metodo en el cual se verificara que se realizo el logueo exitosamente
        public void SuccessLoginT()
        {
            try
            {
                LoginAut loginAut = new LoginAut(driver);
                Employee employee = loginAut.LoginAs("Alan", "1234");
                Console.WriteLine("Ingreso Correcto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error" + ex.Message);
            }


        }






    }
}
