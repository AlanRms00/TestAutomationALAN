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
        protected By RegrespFecha = By.XPath("//*[@id='mainpanel']/div[2]/form/div[2]/div[4]/div");//El formato que sigue es MM/DD/YYYY Se le envia como texto 
        protected By ClaseViaje = By.Id("classId");//Se modifica mediante la posicion del objeto en la lista
        protected By Pasajeros = By.XPath("//*[@id='passenger']");//Cantidad de pasajeros se busca mediante una lista de objetos
        protected By BtnBuscarViaje = By.Id("//*[@id='mainpanel']/div[2]/form/div[4]/div/button");//Botón de buscar viaje

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
    }
}











