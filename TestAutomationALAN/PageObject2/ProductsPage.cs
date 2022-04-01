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
        //Definimos como y con que se deben buscar los elementos en la web 
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
            //Driver utilizado
            Driver = driver;
            }


        public void EnterName(String name)
        {
            //Elemento para ingresar nombre 
            WaitHandler.ElementIsPresent(Driver, Name);
            Driver.FindElement(Name).SendKeys(name);
        }

        public void EnterPrice(String price)
        {
            //Elemento para ingresar precio
            WaitHandler.ElementIsPresent(Driver, Price);
                Driver.FindElement(Price).SendKeys(price);
        }

        public void SelectModel(String model)
        {
            //Elemento para buscar por modelo
            WaitHandler.ElementIsPresent(Driver, Model);
            Driver.FindElements(Model);

        }

        public bool FilterButton()
        {
            //Busca el boton "Filter" nos regresa si se encuentra presente 
            Driver.FindElement(filter);
            return WaitHandler.ElementIsPresent(Driver, filter);
        }

        public bool ClearButton()
        {
            //Busca el boton "Clear" nos regresa si se encuentra presente 
            Driver.FindElement(Clear).Click();
            return WaitHandler.ElementIsPresent(Driver, Clear);
        }
        public bool AddButton()
        {
            //Busca el boton "Add" nos regresa si se encuentra presente
            Driver.FindElement(Add).Click();
            return WaitHandler.ElementIsPresent(Driver, Add);
        }
        public void FormAdd()
        {
            //Busca el elemento nombre
            WaitHandler.ElementIsPresent(Driver, AddProduct_Name);
            Driver.FindElement(AddProduct_Name);
            //Busca el elemento precio
            WaitHandler.ElementIsPresent(Driver, AddProduct_Price);
            Driver.FindElement(AddProduct_Price);
            //Busca Modelo en lista
            WaitHandler.ElementIsPresent(Driver, AddProduct_Model);
            Driver.FindElements(AddProduct_Model);
           
        }
      
    }
}
