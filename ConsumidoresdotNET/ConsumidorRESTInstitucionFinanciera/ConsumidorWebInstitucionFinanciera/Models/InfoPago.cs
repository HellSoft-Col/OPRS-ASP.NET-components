using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumidorWebInstitucionFinanciera.Models
{
    public class InfoPago
    {
        public string tipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public string contraseña { get; set; }
        public Nullable<int> monto { get; set; }

        public InfoPago(string tipoDoc, string numDoc, string password, int discountValue)
        {
            this.tipoDocumento = tipoDoc;
            this.numDocumento = numDoc;
            this.contraseña = password;
            this.monto = discountValue;
        }
    }
}