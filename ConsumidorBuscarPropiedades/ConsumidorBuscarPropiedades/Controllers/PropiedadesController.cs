using ConsumidorBuscarPropiedades.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ConsumidorBuscarPropiedades.Controllers
{
    public class PropiedadesController : Controller
    {
        string Baseurl = "http://localhost:8080/ServiciosRESTOPRS/webresources/serachProperty";
        // GET: Propiedades
        public ActionResult Index()
        {
            return View();
        }

        // POST: Propiedades
        [HttpPost]
        public ActionResult Index(string owner_id = "Default", float minPrice = -1, float maxPrice = -1)
        {
            IEnumerable<Propiedad> propiedad = null;

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
                else
                {
                    propiedad = Enumerable.Empty<Propiedad>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(propiedad);
        }

        // GET: Propiedades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Propiedades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propiedades/Create
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

        // GET: Propiedades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Propiedades/Edit/5
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

        // GET: Propiedades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Propiedades/Delete/5
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
