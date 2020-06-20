using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CafeteriaUnapec.Models;

namespace CafeteriaUnapec.Controllers
{
    public class CafeteriaController : Controller
    {
        private CafeteriaCafeteriaUnapec db = new CafeteriaCafeteriaUnapec();

        // GET: Cafeteria
        public ActionResult Index()
        {
            return View(db.Cafeteria.ToList());
        }

        // GET: Cafeteria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cafeteria cafeteria = db.Cafeteria.Find(id);
            if (cafeteria == null)
            {
                return HttpNotFound();
            }
            return View(cafeteria);
        }

        // GET: Cafeteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cafeteria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descripcion,Estado")] Cafeteria cafeteria)
        {
            if (ModelState.IsValid)
            {
                db.Cafeteria.Add(cafeteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cafeteria);
        }

        // GET: Cafeteria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cafeteria cafeteria = db.Cafeteria.Find(id);
            if (cafeteria == null)
            {
                return HttpNotFound();
            }
            return View(cafeteria);
        }

        // POST: Cafeteria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descripcion,Estado")] Cafeteria cafeteria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cafeteria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cafeteria);
        }

        // GET: Cafeteria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cafeteria cafeteria = db.Cafeteria.Find(id);
            if (cafeteria == null)
            {
                return HttpNotFound();
            }
            return View(cafeteria);
        }

        // POST: Cafeteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cafeteria cafeteria = db.Cafeteria.Find(id);
            db.Cafeteria.Remove(cafeteria);
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
