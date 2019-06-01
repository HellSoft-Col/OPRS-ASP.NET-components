using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumidorBuscarPropiedades.Models
{
    public class Propiedad
    {
        public long type { get; set; }
        public string address { get; set; }
        public long roomsNumber { get; set; }
        public decimal rent { get; set; }
        public string location { get; set; }
    }
}