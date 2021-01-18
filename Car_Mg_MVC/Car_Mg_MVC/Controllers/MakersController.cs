using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car_Mg_MVC.Models;

namespace Car_Mg_MVC.Controllers
{
    public class MakersController : Controller
    {
        private DB_CarEntities db = new DB_CarEntities();

        // GET: Makers
        public ActionResult Index(string IdSearch)
        {
            var maker = db.Makers.Include(m => m.Cars);
            if (!string.IsNullOrEmpty(IdSearch))
            {
                maker = maker.Where(m => m.MakerName.Contains(IdSearch));
                
            }
            ViewBag.soluong = maker.Count();
            return View(maker.ToList());
        }

        // GET: Makers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maker maker = db.Makers.Find(id);
            if (maker == null)
            {
                return HttpNotFound();
            }
            return View(maker);
        }

        // GET: Makers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Makers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MakerId,MakerName")] Maker maker)
        {
            if (ModelState.IsValid)
            {
                db.Makers.Add(maker);
                db.SaveChanges();
                TempData["thongbao"] = "Thêm maker mời : " + maker.MakerName + " Thành công " + maker.MakerId.ToString();
                return RedirectToAction("Index");
            }

            return View(maker);
        }

        // GET: Makers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maker maker = db.Makers.Find(id);
            if (maker == null)
            {
                return HttpNotFound();
            }
            return View(maker);
        }

        // POST: Makers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MakerId,MakerName")] Maker maker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maker).State = EntityState.Modified;
                db.SaveChanges();
                TempData["thongbao"] = "Sửa maker mời : " + maker.MakerName + " Thành công ID : " + maker.MakerId.ToString();
                return RedirectToAction("Index");
            }
            return View(maker);
        }

        // GET: Makers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maker maker = db.Makers.Find(id);
            if (maker == null)
            {
                return HttpNotFound();
            }
            return View(maker);
        }

        // POST: Makers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maker maker = db.Makers.Find(id);
            db.Makers.Remove(maker);
            db.SaveChanges();
           // TempData["thongbao"] = "Xóa maker : " + maker.MakerName + " Thành công : " + maker.MakerId.ToString();
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
