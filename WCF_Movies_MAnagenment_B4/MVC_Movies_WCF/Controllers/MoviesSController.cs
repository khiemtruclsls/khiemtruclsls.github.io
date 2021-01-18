using MVC_Movies_WCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Movies_WCF.Controllers
{
    public class MoviesSController : Controller
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        // GET: MoviesS

        public ActionResult Index() 
        {
            return View(client.GetAll());
        }

        // GET: MoviesS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MoviesS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesS/Create
        [HttpPost]
        public ActionResult Create(Movie m)
        {
            try
            {
                // TODO: Add insert logic here
                client.Add(m);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesS/Edit/5
        public ActionResult Edit(int id)
        {   
            return View();
        }

        // POST: MoviesS/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie m)
        {
            try
            {

                // TODO: Add update logic here
                client.Edit(m);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviesS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Movie m)
        {
            try
            {
                client.Delete(id);
                // TODO: Add delete logic here
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
