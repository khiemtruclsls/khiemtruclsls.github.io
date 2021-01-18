using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_QLSVV.Models;

namespace MVC_QLSVV.Controllers
{
    public class SubjectSController : Controller
    {
        private DataContext db = new DataContext();

        // GET: SubjectS
        public ActionResult Index()
        {
            return View(db.DsSubject.ToList());
        }

        // GET: SubjectS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectS subjectS = db.DsSubject.Find(id);
            if (subjectS == null)
            {
                return HttpNotFound();
            }
            return View(subjectS);
        }

        // GET: SubjectS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectId,SubjectName")] SubjectS subjectS)
        {
            if (ModelState.IsValid)
            {
                db.DsSubject.Add(subjectS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subjectS);
        }

        // GET: SubjectS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectS subjectS = db.DsSubject.Find(id);
            if (subjectS == null)
            {
                return HttpNotFound();
            }
            return View(subjectS);
        }

        // POST: SubjectS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectId,SubjectName")] SubjectS subjectS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjectS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subjectS);
        }

        // GET: SubjectS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectS subjectS = db.DsSubject.Find(id);
            if (subjectS == null)
            {
                return HttpNotFound();
            }
            return View(subjectS);
        }

        // POST: SubjectS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubjectS subjectS = db.DsSubject.Find(id);
            db.DsSubject.Remove(subjectS);
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
