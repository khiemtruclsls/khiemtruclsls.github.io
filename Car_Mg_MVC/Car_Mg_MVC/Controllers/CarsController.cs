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
    public class CarsController : Controller
    {
        private DB_CarEntities db = new DB_CarEntities();

        // GET: Cars
        public ActionResult Index(string IdSearch , int _carMakerID = 0 )
        {
            ViewBag._carMakerID = new SelectList(db.Makers, "MakerId", "MakerName");
            var cars = db.Cars.Include(c => c.Maker);
            if (!string.IsNullOrEmpty(IdSearch))
            {
                cars = cars.Where(c => c.CarModel.Contains(IdSearch));

            }
            if(_carMakerID > 0)
            {
                cars = cars.Where(c => c.CarMakerID == _carMakerID);
            }
            ViewBag.SoLuongXe = cars.Count();
            return View(cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            ViewBag.CarMakerID = new SelectList(db.Makers, "MakerId", "MakerName");
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarId,CarModel,CarModelYear,CarVIN,CarMakerID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                TempData["Mess"] = "Them xe moi " +car.CarModel+ " Thành công ID : " +car.CarId.ToString();
                return RedirectToAction("Index");
            }

            ViewBag.CarMakerID = new SelectList(db.Makers, "MakerId", "MakerName", car.CarMakerID);
            return View(car);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarMakerID = new SelectList(db.Makers, "MakerId", "MakerName", car.CarMakerID);
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarId,CarModel,CarModelYear,CarVIN,CarMakerID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Mess"] = "Sửa xe  " + car.CarModel + " Thành công ID : " + car.CarId.ToString();
                return RedirectToAction("Index");
            }
            ViewBag.CarMakerID = new SelectList(db.Makers, "MakerId", "MakerName", car.CarMakerID);
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            TempData["Mess"] = "Xóa xe " + car.CarModel + " Thành công ID : " + car.CarId.ToString();
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
