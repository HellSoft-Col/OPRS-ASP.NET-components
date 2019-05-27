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

namespace RESTInstitucionFinanciera
{
    public class payment_formController : ApiController
    {
        private FacadeValidarInfoPago fvip = new FacadeValidarInfoPago();

        // GET: api/payment_form
        public IQueryable<payment_form> Getpayment_form()
        {
            //return db.payment_form;
            return fvip.Getpayment_form();
        }

        // POST: api/payment_form
        [ResponseType(typeof(payment_form))]
        public IHttpActionResult Postpayment_form(payment_form payment_form)
        {
            payment_form payment = fvip.validar(payment_form);
            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }
    }
}