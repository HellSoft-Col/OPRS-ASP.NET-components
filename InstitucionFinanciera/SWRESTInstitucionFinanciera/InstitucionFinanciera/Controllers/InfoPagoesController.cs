using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using InstitucionFinanciera.Models;

namespace InstitucionFinanciera.Controllers
{
    public class InfoPagoesController : ApiController
    {
        private FacadeValidarInfoPago facade = new FacadeValidarInfoPago();

        // GET: api/InfoPagoes
        public IQueryable<InfoPago> GetInfoPago()
        {
            return facade.GetInfoPago();
        }

        // POST: api/InfoPagoes
        [ResponseType(typeof(Comprobante))]
        public IHttpActionResult PostInfoPago(InfoPago infoPago)
        {
            Comprobante resultado = facade.validar(infoPago);
            if (resultado != null)
                return Ok(resultado);
            return NotFound();
        }
    }
}