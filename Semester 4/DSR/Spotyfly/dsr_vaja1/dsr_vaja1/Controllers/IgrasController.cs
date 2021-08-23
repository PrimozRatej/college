using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dsr_vaja1.DAL;
using dsr_vaja1.Models.Igra;

namespace dsr_vaja1.Controllers
{
   
    public class IgrasController : Controller
    {
        private IgraContext db = new IgraContext();

        // GET: Igras
        public ActionResult Index()
        {
            return View(db.Igre.ToList());
        }

        // GET: Igras/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Igra igra = db.Igre.Find(id);
            if (igra == null)
            {
                return HttpNotFound();
            }
            return View(igra);
        }

        // GET: Igras/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new Igra());
        }

        // POST: Igras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "Id,ime,proizvajalec,cena,datum_prihoda,zaloga,Zvrsti")] Igra igra)
        {
            if (ModelState.IsValid)
            {
                db.Igre.Add(igra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(igra);
        }

        // GET: Igras/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Igra igra = db.Igre.Find(id);
            if (igra == null)
            {
                return HttpNotFound();
            }
            return View(igra);
        }

        // POST: Igras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "Id,ime,proizvajalec,cena,datum_prihoda,zaloga,Zvrsti")] Igra igra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(igra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(igra);
        }

        // GET: Igras/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Igra igra = db.Igre.Find(id);
            if (igra == null)
            {
                return HttpNotFound();
            }
            return View(igra);
        }

        // POST: Igras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Igra igra = db.Igre.Find(id);
            db.Igre.Remove(igra);
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
