using ConsumidorBuscarPropiedades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Web.ModelBinding;

namespace ConsumidorBuscarPropiedades.Proxys
{
    public class ProxyRESTBuscarPropiedades
    {
        private string Baseurl = "http://localhost:8080/ServiciosRESTOPRS/webresources/serachProperty";

        public List<Propiedad> ObtenerPropiedades(string owner_id, float minPrice, float maxPrice)
        {
            List<Propiedad> propiedad = null;
            using (var client = new HttpClient())
            {
                PropertyQueryDTO busqueda;
                busqueda = new PropertyQueryDTO(minPrice, maxPrice, owner_id);
                var myContent = JsonConvert.SerializeObject(busqueda);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var responseTask = client.PostAsync(Baseurl, byteContent);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    propiedad = JsonConvert.DeserializeObject<List<Propiedad>>(readTask);
                }
            }
            return propiedad;
        }
    }
}