using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PenalizeManagement.Models;

namespace PenalizeManagement.Controllers
{
    public class PenalizesController : Controller
    {
        private MyDataContext db = new MyDataContext();

        // GET: Penalizes
        public ActionResult Index()
        {
            return View(db.Penalizes.ToList());
        }

        // GET: Penalizes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penalize penalize = db.Penalizes.Find(id);
            if (penalize == null)
            {
                return HttpNotFound();
            }
            return View(penalize);
        }

        // GET: Penalizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Penalizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RollNumber,PenaltyOption,amount")] Penalize penalize)
        {
            penalize.Deadline = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Penalizes.Add(penalize);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(penalize);
        }

        // GET: Penalizes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penalize penalize = db.Penalizes.Find(id);
            if (penalize == null)
            {
                return HttpNotFound();
            }
            return View(penalize);
        }

        // POST: Penalizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RollNumber,PenaltyOption,amount,Deadline")] Penalize penalize)
        {
            if (ModelState.IsValid)
            {
                db.Entry(penalize).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(penalize);
        }

        // GET: Penalizes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penalize penalize = db.Penalizes.Find(id);
            if (penalize == null)
            {
                return HttpNotFound();
            }
            return View(penalize);
        }

        // POST: Penalizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Penalize penalize = db.Penalizes.Find(id);
            db.Penalizes.Remove(penalize);
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
