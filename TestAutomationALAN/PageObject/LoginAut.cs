using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationALAN.Handler;

namespace TestAutomationALAN.PageObject
{
    /*Clase para representar la pagina IniciarSesion */
    public class LoginAut
    {
        //Selenium Driver
        protected IWebDriver Driver;

        //Localizadores
        protected By User = By.Id("user");
        protected By Password = By.Id("pass");
        protected By Enter = By.Id("loginButton");
    

    public LoginAut (IWebDriver driver)
    {
         Driver = driver;
            driver.Title.Equals("AUT Login – TestFaceClub");
            

    }
        //Metodo para escribir el usuario 
        public void typeUserName(string user)
        {
            WaitHandler.ElementIsPresent(Driver,User);
            Driver.FindElement(User).SendKeys("Alan");
        }

        //Metodo para escribir Contraseña
        public void TypePass(string pass)
        {
            WaitHandler.ElementIsPresent(Driver, Password);
            Driver.FindElement(Password).SendKeys("1234");
        }

        //Metodo para hacer clic en el boton de inicio sesion 
        public void TypeButton()
        {
            WaitHandler.ElementIsPresent(Driver, Enter);
            Driver.FindElement(Enter).Submit();
        }

        public Employee LoginAs (String user, String password)
        {
            typeUserName(user); 
            TypePass(password);
            TypeButton();

            return new Employee(Driver);
        }
    }
}
