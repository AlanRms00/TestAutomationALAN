using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationALAN.PageObject2;

namespace TestAutomationALAN.TestCasePO2
{
    public class TestPO1
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforTest()
        {
            driver = new ChromeDriver(@"C:\Users\alanp\Downloads\chromedriver_win32 (1)\chromedriver_win32 (2)");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.testfaceclub.com/aut-products/");
        }
        [Test]

        public void AddProduct()
        {

            ProductsPage productsPage = new ProductsPage(driver);
            productsPage.AddButton();

        }

    }
}
