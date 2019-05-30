using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumidorWebInstitucionFinanciera.Models
{
    public class Comprobante
    {
        public string numAprobacion { get; set; }
        public string aprobacion { get; set; }

        public Comprobante(string numAprobacion, string aprobacion)
        {
            this.numAprobacion = numAprobacion;
            this.aprobacion = aprobacion;
        }
    }
}