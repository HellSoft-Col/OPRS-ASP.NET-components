using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSSOAPInsFinanciera
{
    public class WCFIFController : Controller
    {
        // GET: WCFIF
        public ActionResult Index()
        {
            return View();
        }
        //POST: WCFIF
        [HttpPost]
        public ActionResult Index(string tipoDoc, string numDoc, string password, int discountValue)
        {
            ValidarInfoPago(tipoDoc, numDoc, password, discountValue);
            return View("ValidarInfoPago");
        }
        public ActionResult ValidarInfoPago(string tipoDoc, string numDoc, string password, int discountValue)
        {
            proxyInsFinanciera.SOAPInsFinancieraClient proxy = new proxyInsFinanciera.SOAPInsFinancieraClient();
            proxyInsFinanciera.InfoPago iP = new proxyInsFinanciera.InfoPago();
            iP.tipoDocumento = tipoDoc;
            iP.numDocumento = numDoc;
            iP.contraseña = password;
            iP.monto = discountValue;
            proxyInsFinanciera.Comprobante result = proxy.validar(iP);
            return View(result);
        }
    }
}