using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumidorBuscarPropiedades.Models
{
    public class PropertyQueryDTO
    {
        public float minimalRent { get; set; }
        public float maximalRent { get; set; }
        [Required]
        public string cedulaProp { get; set; }

        public PropertyQueryDTO()
        {
        }

        public PropertyQueryDTO(string cedulaProp)
        {
            this.cedulaProp = cedulaProp;
        }
        public PropertyQueryDTO(float rent, int opt)
        {
            if(opt == 0)
            {
                this.minimalRent = rent;
            }
            else
            {
                this.maximalRent = rent;
            }
        }
        public PropertyQueryDTO(float minimalRent, float maximalRent, string cedulaProp)
        {
            this.minimalRent = minimalRent;
            this.maximalRent = maximalRent;
            this.cedulaProp = cedulaProp;
        }
    }
}