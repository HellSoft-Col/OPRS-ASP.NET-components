using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumidorWebInstitucionFinanciera.Models
{
    public class ServicioIF
    {
        public string tipoDoc { get; set; }
        public int numDoc { get; set; }
        public string password { get; set; }
        public float discountValue { get; set; }

        public ServicioIF(string tipoDoc, int numDoc, string password, float discountValue)
        {
            this.tipoDoc = tipoDoc;
            this.numDoc = numDoc;
            this.password = password;
            this.discountValue = discountValue;
        }
    }
}