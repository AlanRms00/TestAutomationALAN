using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationALAN.Handler;

namespace TestAutomationALAN.PageObject2
{
    public class ProductsPage
    {
        protected IWebDriver Driver;
        protected By Name = By.Id("inputName");
        protected By Price = By.Id("inputPrice");
        protected By Model = By.Id("productModel");
        protected By filter = By.Id("filterButton");
        protected By Clear = By.Id("ResetButton");
        protected By Add = By.Id("Add");
        protected By DeleteRecentProducts = By.XPath("//*[@id='content']/article/div/div/div/div/section/div/div/div/div/div/div/div/div/div[2]/div[1]/div/p/button[2]");
        protected By AddProduct_Name = By.Id("inputName2");
        protected By AddProduct_Price = By.XPath("//*[@id='inputPrice']");
        protected By AddProduct_Model = By.XPath("//*[@id='productModel']/div[1]/span");
        protected By AddProduct_Add = By.XPath("//*[@id='myModal']/div/div/div[3]/button[2]");
        protected By AddProduct_Close = By.XPath("//*[@id='myModal']/div/div/div[3]/button[1]");


        public ProductsPage(IWebDriver driver){

            Driver = driver;
            }


        public void EnterName(String name)
        {
            WaitHandler.ElementIsPresent(Driver, Name);
            Driver.FindElement(Name).SendKeys(name);
        }

        public void EnterPrice(String price)
        {
            WaitHandler.ElementIsPresent(Driver, Price);
                Driver.FindElement(Price).SendKeys(price);
        }

    }
}
