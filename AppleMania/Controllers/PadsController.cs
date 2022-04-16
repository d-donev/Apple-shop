using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppleMania.Models;

namespace AppleMania.Controllers
{
    public class PadsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pads
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Pads.ToList());
        }

        // GET: Pads/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pad pad = db.Pads.Find(id);
            if (pad == null)
            {
                return HttpNotFound();
            }
            return View(pad);
        }

        // GET: Pads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Model,ImageURL,ReleaseDate,Price,Width,Height,Weigth,Memory,Camera,Speakers,Os,Chip")] Pad pad)
        {
            if (ModelState.IsValid)
            {
                db.Pads.Add(pad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pad);
        }

        // GET: Pads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pad pad = db.Pads.Find(id);
            if (pad == null)
            {
                return HttpNotFound();
            }
            return View(pad);
        }

        // POST: Pads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Model,ImageURL,ReleaseDate,Price,Width,Height,Weigth,Memory,Camera,Speakers,Os,Chip")] Pad pad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pad);
        }

        // GET: Pads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pad pad = db.Pads.Find(id);
            if (pad == null)
            {
                return HttpNotFound();
            }
            return View(pad);
        }

        // POST: Pads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pad pad = db.Pads.Find(id);
            db.Pads.Remove(pad);
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
