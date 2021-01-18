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
    public class DiemThisController : Controller
    {
        private QldtDBEntities db = new QldtDBEntities();

        // GET: DiemThis
        public ActionResult Index()
        {
            var diemThis = db.DiemThis.Include(d => d.HocVien).Include(d => d.MonHoc);
            return View(diemThis.ToList());
        }

        // GET: DiemThis/Details/5
        public ActionResult Details(int idHocvien , int idMonhoc , int lanthi )
        { 
            if(idHocvien <= 0 || idMonhoc <= 0 || lanthi <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(idHocvien,idMonhoc,lanthi);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            return View(diemThi);
        }

        // GET: DiemThis/Create
        public ActionResult Create()
        {
            ViewBag.IdHocVien = new SelectList(db.HocViens, "Id", "HoTen");
            ViewBag.IdMonHoc = new SelectList(db.MonHocs, "Id", "TenMonHoc");
            return View();
        }

        // POST: DiemThis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdHocVien,IdMonHoc,LanThi,DiemThi1")] DiemThi diemThi)
        {
            if (ModelState.IsValid)
            {
                db.DiemThis.Add(diemThi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdHocVien = new SelectList(db.HocViens, "Id", "HoTen", diemThi.IdHocVien);
            ViewBag.IdMonHoc = new SelectList(db.MonHocs, "Id", "TenMonHoc", diemThi.IdMonHoc);
            return View(diemThi);
        }

        // GET: DiemThis/Edit/5
        public ActionResult Edit(int idHocvien, int idMonhoc, int lanthi)
        {
            if (idHocvien <= 0 || idMonhoc <= 0 || lanthi <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(idHocvien, idMonhoc, lanthi);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdHocVien = new SelectList(db.HocViens, "Id", "HoTen", diemThi.IdHocVien);
            ViewBag.IdMonHoc = new SelectList(db.MonHocs, "Id", "TenMonHoc", diemThi.IdMonHoc);
            return View(diemThi);
        }

        // POST: DiemThis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdHocVien,IdMonHoc,LanThi,DiemThi1")] DiemThi diemThi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diemThi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdHocVien = new SelectList(db.HocViens, "Id", "HoTen", diemThi.IdHocVien);
            ViewBag.IdMonHoc = new SelectList(db.MonHocs, "Id", "TenMonHoc", diemThi.IdMonHoc);
            return View(diemThi);
        }

        // GET: DiemThis/Delete/5
        public ActionResult Delete(int idHocvien, int idMonhoc, int lanthi)
        {
            if (idHocvien <= 0 || idMonhoc <= 0 || lanthi <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiemThi diemThi = db.DiemThis.Find(idHocvien,idMonhoc,lanthi);
            if (diemThi == null)
            {
                return HttpNotFound();
            }
            return View(diemThi);
        }

        // POST: DiemThis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiemThi diemThi = db.DiemThis.Find(id);
            db.DiemThis.Remove(diemThi);
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
