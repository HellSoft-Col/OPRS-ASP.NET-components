using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTInstitucionFinanciera
{
    public class FacadeValidarInfoPago
    {
        private BDInsFinancieraEntities db = new BDInsFinancieraEntities();

        public payment_form validar(payment_form input)
        {
            payment_form payment = (from p in db.payment_form
                                    where p.type_credit_card == input.type_credit_card &&
                                    p.credit_card_number ==input.credit_card_number &&
                                    p.name_holder == input.name_holder &&
                                    p.customer_id == input.customer_id
                                    select p).SingleOrDefault();

            if (payment != default(payment_form))
                return payment;
            return null;
        }

        public IQueryable<payment_form> Getpayment_form()
        {
            return db.payment_form;
        }

    }
}