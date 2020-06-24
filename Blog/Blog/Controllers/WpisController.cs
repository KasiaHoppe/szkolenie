using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class WpisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Wpis
        public ActionResult Index()
        {
            return View(db.Wpisy.ToList());
        }

        // GET: Wpis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wpis wpis = db.Wpisy.Find(id);
            if (wpis == null)
            {
                return HttpNotFound();
            }
            return View(wpis);
        }

        // GET: Wpis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wpis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tytul,Autor,Tresc,DataDodania,IdKategoria")] Wpis wpis)
        {
            if (ModelState.IsValid)
            {
                db.Wpisy.Add(wpis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wpis);
        }

        // GET: Wpis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wpis wpis = db.Wpisy.Find(id);
            if (wpis == null)
            {
                return HttpNotFound();
            }
            return View(wpis);
        }

        // POST: Wpis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tytul,Autor,Tresc,DataDodania,IdKategoria")] Wpis wpis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wpis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wpis);
        }

        // GET: Wpis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wpis wpis = db.Wpisy.Find(id);
            if (wpis == null)
            {
                return HttpNotFound();
            }
            return View(wpis);
        }

        // POST: Wpis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wpis wpis = db.Wpisy.Find(id);
            db.Wpisy.Remove(wpis);
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
