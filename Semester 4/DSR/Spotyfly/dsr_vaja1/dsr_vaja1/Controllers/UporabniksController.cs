using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dsr_vaja1.DAL;
using dsr_vaja1.Models.Uporabnik;

namespace dsr_vaja1.Controllers
{
    public class UporabniksController : Controller
    {
        private UporabnikContext db = new UporabnikContext();

        // GET: Uporabniks
        public ActionResult Index()
        {
            return View(db.Uporabniki.ToList());
        }

        // GET: Uporabniks/Details/5
        [Authorize(Roles ="Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uporabnik uporabnik = db.Uporabniki.Find(id);
            if (uporabnik == null)
            {
                return HttpNotFound();
            }
            return View(uporabnik);
        }


        [Authorize(Roles = "Admin")]
        // GET: Uporabniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uporabnik uporabnik = db.Uporabniki.Find(id);
            if (uporabnik == null)
            {
                return HttpNotFound();
            }
            return View(uporabnik);
        }

        // POST: Uporabniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "Id,ime,priimek,rojstni_datum,Kraji,emso,Starost,naslov,email,posta,drzava,postna_stevilka,geslo,ponovi_geslo")] Uporabnik uporabnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uporabnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uporabnik);
        }

        // GET: Uporabniks/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uporabnik uporabnik = db.Uporabniki.Find(id);
            if (uporabnik == null)
            {
                return HttpNotFound();
            }
            return View(uporabnik);
        }

        // POST: Uporabniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Uporabnik uporabnik = db.Uporabniki.Find(id);
            db.Uporabniki.Remove(uporabnik);
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
