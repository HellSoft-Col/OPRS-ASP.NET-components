using InstitucionFinanciera.Controllers;
using InstitucionFinanciera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfInsFinanciera
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SOAPInsFinanciera" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SOAPInsFinanciera.svc o SOAPInsFinanciera.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SOAPInsFinanciera : ISOAPInsFinanciera
    {
        private FacadeValidarInfoPago facade = new FacadeValidarInfoPago();

        public Comprobante validar(InfoPago infoPago)
        {
            Comprobante resultado = facade.validar(infoPago);
            if (resultado != null)
                return resultado;
            return null;
        }

        public void DoWork()
        {
        }
    }
}
