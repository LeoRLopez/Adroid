﻿using ConsultorioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FacturasController : Controller
    {
        private ClinicaEntities db = new ClinicaEntities();

        // GET: Facturas
        public ActionResult Index()
        {
            var factura = db.Factura.Include(f => f.FormaDePago).Include(f => f.Tarjetas);
            return View(factura.ToList());
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre");
            ViewBag.IdTarjeta = new SelectList(db.Tarjetas, "IdTarjeta", "Nombre");
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFactura,IdTurno,Fecha,IdFormaDePago,Monto,Descripcion,IdTarjeta")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Factura.Add(factura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", factura.IdFormaDePago);
            ViewBag.IdTarjeta = new SelectList(db.Tarjetas, "IdTarjeta", "Nombre", factura.IdTarjeta);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", factura.IdFormaDePago);
            ViewBag.IdTarjeta = new SelectList(db.Tarjetas, "IdTarjeta", "Nombre", factura.IdTarjeta);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFactura,IdTurno,Fecha,IdFormaDePago,Monto,Descripcion,IdTarjeta")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFormaDePago = new SelectList(db.FormaDePago, "IdFormaDePago", "Nombre", factura.IdFormaDePago);
            ViewBag.IdTarjeta = new SelectList(db.Tarjetas, "IdTarjeta", "Nombre", factura.IdTarjeta);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Factura factura = db.Factura.Find(id);
            db.Factura.Remove(factura);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
