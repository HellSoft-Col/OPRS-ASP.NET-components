using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstitucionFinanciera.Models
{
    public class Comprobante
    {
        public string numAprobacion { get; set; }

        public string aprobacion { get; set; }

        public Comprobante()
        {
            numAprobacion = Guid.NewGuid().ToString();
            aprobacion = DateTime.Now.ToString("d");
        }
    }
}