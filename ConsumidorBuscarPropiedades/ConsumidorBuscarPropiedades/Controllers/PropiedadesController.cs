using ConsumidorBuscarPropiedades.Models;
using ConsumidorBuscarPropiedades.Proxys;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ConsumidorBuscarPropiedades.Controllers
{
    public class PropiedadesController : Controller
    {
        ProxyRESTBuscarPropiedades proxyREST = new ProxyRESTBuscarPropiedades();
        // GET: Propiedades
        public ActionResult Index()
        {
            return View();
        }

        // POST: Propiedades
        [HttpPost]
        public ActionResult Index(string owner_id = "Default", float minPrice = -1, float maxPrice = -1)
        {
            IEnumerable<Propiedad> propiedad = proxyREST.ObtenerPropiedades(owner_id,minPrice, maxPrice);
            if(propiedad == null)
            {
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
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
