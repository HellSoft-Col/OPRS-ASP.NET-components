using ConsumidorWebInstitucionFinanciera.Models;
using ConsumidorWebInstitucionFinanciera.Proxys;
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
        ProxyRESTIF proxyIF = new ProxyRESTIF();
        // GET: Servicios
        public ActionResult Index()
        {
            return View();
        }

        // POST: Servicios
        [HttpPost]
        public ActionResult Index(string tipoDoc, string numDoc, string password, int discountValue)
        {
            Comprobante aprobacion = proxyIF.ConsumirServicioIF(tipoDoc, numDoc, password, discountValue);
            if(aprobacion == null)
            {
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
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
