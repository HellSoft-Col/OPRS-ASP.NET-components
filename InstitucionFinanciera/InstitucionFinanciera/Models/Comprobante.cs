using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstitucionFinanciera.Models
{
    public class Comprobante
    {
        public int numAprobacion { get; set; }

        public string aprobacion { get; set; }

        public Comprobante()
        {
            Random random = new Random();
            numAprobacion = random.Next();
            aprobacion = DateTime.Now.ToString("d");
        }
    }
}