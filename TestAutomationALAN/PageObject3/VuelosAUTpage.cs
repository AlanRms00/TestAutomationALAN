using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestAutomationALAN.Handler;

namespace TestAutomationALAN.PageObject3
{
    public class VuelosAUTpage
    {
        protected IWebDriver Driver;
        protected By IdaVuelta = By.XPath("//*[@id='mainpanel']/div[2]/form/div[1]/div/label[1]");
        protected By SoloIda = By.XPath("//*[@id='mainpanel']/div[2]/form/div[1]/div/label[2]");
        protected By Desde = By.Id("from");//Se necesita agregar la posicion en la lista, cuando se utilice
        protected By ADonde = By.Id("To");//se necesita agregar la posicon del objeto en la lista
        protected By SalidaFecha = By.Id("//*[@id='mainpanel']/div[2]/form/div[2]/div[3]/div");//El formato que sigue es MM/DD/YYYY se le envia como texto 
        protected By RegrespFecha = By.XPath("document.querySelector('#date')");//El formato que sigue es MM/DD/YYYY Se le envia como texto 
        protected By ClaseViaje = By.Id("classId");//Se modifica mediante la posicion del objeto en la lista
        protected By Pasajeros = By.XPath("//*[@id='passenger']");//Cantidad de pasajeros se busca mediante una lista de objetos
        protected By BtnBuscarViaje = By.Id("//*[@id='mainpanel']/div[2]/form/div[4]/div/button");//Botón de buscar viaje
        protected By ValidacionBusquedaUndefined = By.XPath("//*[@id='content']/article/div/div/div/div/section/div/div/div/div/div/div/div/div/div/div[1]/div[2]");

        protected By Regreso = By.XPath("//*[@id='mainpanel']/div[2]/form/div[2]/div[4]/label");

        public VuelosAUTpage(IWebDriver driver)
        {
            Driver = driver;
        }

        /*Pagina para los casos de prueba una vez teniendo mapeados los objetos 
        
         https://www.testfaceclub.com/aut-vuelos/
         */



        public void ViajesPage(IWebDriver driver)
        {
            Driver  = driver;
        }

        public void ViajeRedondo( string idavuelta )
        {

            if( idavuelta == null)
            {
                WaitHandler.ElementIsPresent(Driver, SoloIda);
                Driver.FindElement(SoloIda).Click();
            }
            if( idavuelta != null) { 
            WaitHandler.ElementIsPresent(Driver, IdaVuelta);
            Driver.FindElement(IdaVuelta).Click();
               
            }

            else {


                Console.WriteLine("No se encontraron los objetos");
                
            }
        }

        public void BuscarViajeBtn()
        {
            Thread.Sleep(3000);
            WaitHandler.ElementIsPresent(Driver, BtnBuscarViaje);
            Driver.FindElement(BtnBuscarViaje).Click();
        }

        public void ClaseDeViaje( string clasedeviaje)
        {
            WaitHandler.ElementIsPresent(Driver, ClaseViaje);
            Driver.FindElement(ClaseViaje).SendKeys(clasedeviaje);
        }

        public void CantPasajeros( string pasajeros)
        {
            WaitHandler.ElementIsPresent(Driver, Pasajeros);
            Driver.FindElement(Pasajeros).SendKeys(pasajeros);
        }

        public void FechaSal(string FechaSal)
        {
            WaitHandler.ElementIsPresent(Driver, SalidaFecha);
            Driver.FindElement(SalidaFecha).SendKeys(FechaSal);
        }
       
        public void FechaReg( string FechaReg)
        {
          //  WaitHandler.ElementIsPresent(Driver,RegrespFecha);
            //Driver.FindElement(RegrespFecha).SendKeys(FechaReg);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[1].click();",RegrespFecha);
            RegrespFecha.ToString();
            if (RegrespFecha != null)
            {
                Console.WriteLine(RegrespFecha.ToString());
            }
         
        }

        public void FiltroVuelos(string Redondo , string salida, string regreso, string claaase, string cantidadpasajeros)
        {
            if (Redondo == null)
            {
                WaitHandler.ElementIsPresent(Driver, SoloIda);
                Driver.FindElement(SoloIda).Click();
            }
            if (Redondo != null)
            {
                WaitHandler.ElementIsPresent(Driver, IdaVuelta);
                Driver.FindElement(IdaVuelta).Click();

            }

            else
            {


                Console.WriteLine("No se encontraron los objetos");

            }
            WaitHandler.ElementIsPresent(Driver, SalidaFecha);
            Driver.FindElement(SalidaFecha);
            WaitHandler.ElementIsPresent(Driver, RegrespFecha);
            Driver.FindElement(RegrespFecha);
            WaitHandler.ElementIsPresent(Driver, ClaseViaje);
            Driver.FindElement(ClaseViaje);
            WaitHandler.ElementIsPresent(Driver, Pasajeros);
            Driver.FindElement(Pasajeros);

        }
    }
}











