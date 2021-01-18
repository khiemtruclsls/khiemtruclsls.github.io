using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quan_Ly_Diem_Thi.Models;

namespace Quan_Ly_Diem_Thi.Controllers
{
    public class HocViensController : Controller
    {
        private QldtDBEntities db = new QldtDBEntities();

        // GET: HocViens
        public ActionResult Index()
        {
            var hocViens = db.HocViens.Include(h => h.LopHoc);
            return View(hocViens.ToList());
        }

        // GET: HocViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocVien hocVien = db.HocViens.Find(id);
            if (hocVien == null)
            {
                return HttpNotFound();
            }
            return View(hocVien);
        }

        // GET: HocViens/Create
        public ActionResult Create()
        {
            ViewBag.IdLopHoc = new SelectList(db.LopHocs, "Id", "LopHoc1");
            return View();
        }

        // POST: HocViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HoTen,NgaySinh,Email,SoDT,IdLopHoc")] HocVien hocVien)
        {
            if (ModelState.IsValid)
            {
                db.HocViens.Add(hocVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLopHoc = new SelectList(db.LopHocs, "Id", "LopHoc1", hocVien.IdLopHoc);
            return View(hocVien);
        }

        // GET: HocViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocVien hocVien = db.HocViens.Find(id);
            if (hocVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLopHoc = new SelectList(db.LopHocs, "Id", "LopHoc1", hocVien.IdLopHoc);
            return View(hocVien);
        }

        // POST: HocViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HoTen,NgaySinh,Email,SoDT,IdLopHoc")] HocVien hocVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hocVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLopHoc = new SelectList(db.LopHocs, "Id", "LopHoc1", hocVien.IdLopHoc);
            return View(hocVien);
        }

        // GET: HocViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocVien hocVien = db.HocViens.Find(id);
            if (hocVien == null)
            {
                return HttpNotFound();
            }
            return View(hocVien);
        }

        // POST: HocViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HocVien hocVien = db.HocViens.Find(id);
            db.HocViens.Remove(hocVien);
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
