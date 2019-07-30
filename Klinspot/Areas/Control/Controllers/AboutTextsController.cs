using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Klinspot.Data;
using Klinspot.Models;

namespace Klinspot.Areas.Control.Controllers
{
    public class AboutTextsController : Controller
    {
        private KlinspotContext db = new KlinspotContext();

        // GET: Control/AboutTexts
        public ActionResult Index()
        {
            return View(db.AboutTexts.ToList());
        }

        // GET: Control/AboutTexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutText aboutText = db.AboutTexts.Find(id);
            if (aboutText == null)
            {
                return HttpNotFound();
            }
            return View(aboutText);
        }

        // GET: Control/AboutTexts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/AboutTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text,Photo")] AboutText aboutText)
        {
            if (ModelState.IsValid)
            {
                db.AboutTexts.Add(aboutText);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutText);
        }

        // GET: Control/AboutTexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutText aboutText = db.AboutTexts.Find(id);
            if (aboutText == null)
            {
                return HttpNotFound();
            }
            return View(aboutText);
        }

        // POST: Control/AboutTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text,Photo")] AboutText aboutText)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutText).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutText);
        }

        // GET: Control/AboutTexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutText aboutText = db.AboutTexts.Find(id);
            if (aboutText == null)
            {
                return HttpNotFound();
            }
            return View(aboutText);
        }

        // POST: Control/AboutTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutText aboutText = db.AboutTexts.Find(id);
            db.AboutTexts.Remove(aboutText);
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
