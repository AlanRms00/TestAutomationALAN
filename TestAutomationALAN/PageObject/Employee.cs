using OpenQA.Selenium;
using System;
using System.Threading;
using TestAutomationALAN.Handler;

namespace TestAutomationALAN.PageObject
{
    public class Employee
    {
        protected IWebDriver Driver;

        protected By Page = By.Id("formEmployee");

        protected By Name = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        protected By Email = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        protected By Address = By.Id("address");
        protected By Phone = By.Id("phone");
        protected By Enter = By.Id("addButton");
        protected By Cancel = By.Id("cancelButton");
        protected By AlertMessage = By.LinkText("Aceptar");
        protected By Alert = By.LinkText(" Success! Employee successfully added");


        public Employee(IWebDriver driver)
        {
            Driver = driver;


        }

        public bool LoadPage()
        {
            Driver.FindElement(Page);
            return WaitHandler.ElementIsPresent(Driver, Page);
        }


        //Metodo para ingreso de Nombre
        public void EnterName(String name)
        {
            WaitHandler.ElementIsPresent(Driver, Name);
            Driver.FindElement(Name).SendKeys(name);

        }

        //Metodo para ingreso de Email
        public void EnterEmail(String email)
        {
            WaitHandler.ElementIsPresent(Driver, Email);
            Driver.FindElement(Email).SendKeys(email);


        }

        internal void CloseAlert()
        {
            WaitHandler.ElementIsPresent(Driver, Alert);
            WaitHandler.ElementIsPresent(Driver, AlertMessage);
            Driver.FindElement(AlertMessage).Click();
        }

        //Metodo para ingreso de Email
        public void EnterAdress(String address)
        {
            WaitHandler.ElementIsPresent(Driver, Address);
            Driver.FindElement(Address).SendKeys(address);


        }

        //Metodo para ingreso de Phone
        public void EnterPhone(String phone)
        {
            WaitHandler.ElementIsPresent(Driver, Phone);
            Driver.FindElement(Phone).SendKeys(phone);

        }

        //Metodo para dar clic en enter
        public void EnterClick()
        {
            if (Driver != null)
            {
                WaitHandler.ElementIsPresent(Driver, Enter);
                Driver.FindElement(Enter).Click();

            }
            else
            {
                WaitHandler.ElementIsPresent(Driver, Cancel);
                Driver.FindElement(Cancel).Click();
            }
        }






        public Employee EnterInfo(String name, String email, String address, String phone)
        {
            Thread.Sleep(3000);
            EnterName(name);
            EnterEmail(email);
            EnterAdress(address);
            EnterPhone(phone);
            EnterClick();
            return new Employee(Driver);

        }
    }
}
















