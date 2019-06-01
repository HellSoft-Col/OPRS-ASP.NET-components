using ConsumidorWebInstitucionFinanciera.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace ConsumidorWebInstitucionFinanciera.Proxys
{
    public class ProxyRESTIF
    {
        private string Baseurl = "http://10.192.12.27:8081/api/InfoPagoes";

        public Comprobante ConsumirServicioIF(string tipoDoc, string numDoc, string password, int discountValue)
        {
            Comprobante aprobacion = null;
            using (var client = new HttpClient())
            {
                InfoPago busqueda = new InfoPago(tipoDoc, numDoc, password, discountValue);
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
                    aprobacion = JsonConvert.DeserializeObject<Comprobante>(readTask);
                }
                else
                {
                    aprobacion = null;
                }
            }
            return aprobacion;
        }
    }
}