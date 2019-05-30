using ConsumidorWebInstitucionFinanciera.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ConsumidorWebInstitucionFinanciera.Controllers
{
    public class ServiciosController : Controller
    {
        private string Baseurl = "http://localhost:8080/ServiciosRESTOPRS/webresources/serachProperty";
        // GET: Servicios
        public ActionResult Index()
        {
            return View();
        }

        // POST: Propiedades
        [HttpPost]
        public ActionResult Index(string tipoDoc, int numDoc, string password, float discountValue)
        {
            Aprobacion aprobacion = null;

            using (var client = new HttpClient())
            {
                ServicioIF busqueda;
                busqueda = new ServicioIF(tipoDoc, numDoc, password, discountValue);
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
                    aprobacion = JsonConvert.DeserializeObject<Aprobacion>(readTask);
                }
                else
                {
                    aprobacion = null;
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(aprobacion);
        }

        // GET: Servicios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Servicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Servicios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Servicios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Servicios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Servicios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
