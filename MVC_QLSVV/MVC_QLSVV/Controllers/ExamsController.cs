using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_QLSVV.Models;
using PagedList;

namespace MVC_QLSVV.Controllers
{
    public class ExamsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Exams
        public ActionResult Index(String TxtTimkiem ,int page = 1,int SubjectId = 0 , int khoangdiem= 0)
        {
            ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName");
            ViewBag.ajaxSubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName");
            var dsExam = db.DsExam.Include(e => e.HocVien).Include(e => e.LopHoc);
            if (!string.IsNullOrEmpty(TxtTimkiem))
            {
                dsExam = dsExam.Where(e => e.HocVien.StudentName.Contains(TxtTimkiem) || e.LopHoc.SubjectName.Contains(TxtTimkiem));
            }
            if(SubjectId > 0)
            {
                dsExam = dsExam.Where(e => e.SubjectID == SubjectId);
            }
            if(khoangdiem == 1)
            {
                dsExam = dsExam.Where(e => e.Mark >= 40);
            }
            if(khoangdiem == 2)
            {
                dsExam = dsExam.Where(e => e.Mark < 40);
            }
            dsExam = dsExam.OrderBy(e => e.Mark);
            return View(dsExam.ToPagedList(page,5));
        }
        [HttpPost]
        public ActionResult Index(String ajaxTimkiem, int ajaxSubjectID = 0, int ajaxkhoangdiem = 0 ,bool ajax = true)
        {
            //ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName");
            var dsExam = db.DsExam.Include(e => e.HocVien).Include(e => e.LopHoc);
            if (!string.IsNullOrEmpty(ajaxTimkiem))
            {
                dsExam = dsExam.Where(e => e.HocVien.StudentName.Contains(ajaxTimkiem) || e.LopHoc.SubjectName.Contains(ajaxTimkiem));
            }
            if (ajaxSubjectID > 0)
            {
                dsExam = dsExam.Where(e => e.SubjectID == ajaxSubjectID);
            }
            if (ajaxkhoangdiem == 1)
            {
                dsExam = dsExam.Where(e => e.Mark >= 40);
            }
            if (ajaxkhoangdiem == 2)
            {
                dsExam = dsExam.Where(e => e.Mark < 40);
            }

            return PartialView("AjaxSearch", dsExam.ToList());   //View(dsExam.ToList());
        }
        // GET: Exams/Details/5
        public ActionResult Details(int id, int idsb)
        {
            if (id <= 0 || idsb <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.DsExam.Find(id,idsb);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Exams/Create
        public ActionResult Create()
        {
            ViewBag.StudentID = new SelectList(db.DsStudent, "StudentID", "StudentName");
            ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName");
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectID,StudentID,Mark")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.DsExam.Add(exam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentID = new SelectList(db.DsStudent, "StudentID", "StudentName", exam.StudentID);
            ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName", exam.SubjectID);
            return View(exam);
        }

        // GET: Exams/Edit/5
        public ActionResult Edit(int id, int idsb)
        {
            if (id <= 0 || idsb <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.DsExam.Find(id,idsb);
            if (exam == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(db.DsStudent, "StudentID", "StudentName", exam.StudentID);
            ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName", exam.SubjectID);
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectID,StudentID,Mark")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(db.DsStudent, "StudentID", "StudentName", exam.StudentID);
            ViewBag.SubjectID = new SelectList(db.DsSubject, "SubjectId", "SubjectName", exam.SubjectID);
            return View(exam);
        }

        // GET: Exams/Delete/5
        public ActionResult Delete(int? id,int idsb)
        {
            if (id <= 0 || idsb <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.DsExam.Find(id,idsb);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id, int idsb)
        {
            Exam exam = db.DsExam.Find(id,idsb);
            db.DsExam.Remove(exam);
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
