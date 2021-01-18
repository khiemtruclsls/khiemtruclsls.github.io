using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Movies_DM.Models;
using PagedList;

namespace MVC_Movies_DM.Controllers
{
    public class MoviesController : Controller
    {
        private DB_MoviesEntities db = new DB_MoviesEntities();
        [OutputCache (Duration = 900)]
        // GET: Movies
        public ActionResult Index(string TxtTimkiem , string sapxep , string chieusx,  int page = 1 )
        {
            var movies = db.Movies.Include(m => m.Genre);
            if (!string.IsNullOrEmpty(TxtTimkiem))
            {
                movies = movies.Where(m => m.Title.Contains(TxtTimkiem) );
            }
            if (!string.IsNullOrEmpty(sapxep))
            {
                switch (sapxep)
                {
                    case "Title":
                        if (chieusx == "Xuoi")
                        {
                            movies = movies.OrderBy(m => m.Title);
                        }
                        else
                        {
                            movies = movies.OrderByDescending(m => m.Title);
                        }
                        break;
                    case "RunningTime":
                        if (chieusx == "Xuoi")
                        {
                            movies = movies.OrderBy(m => m.RunningTime);
                        }
                        else
                        {
                            movies = movies.OrderByDescending(m => m.RunningTime);
                        }
                        break;
                        break;

                    default:
                        movies = movies.OrderBy(m => m.Title);
                        break;

                }
            }
            else
            {
                movies = movies.OrderBy(m => m.Title);
            }
            return View(movies.ToPagedList(page , 5));
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreName");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Title,ReleaseDate,RunningTime,GenreId,BoxOffice")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreName", movie.GenreId);
            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreName", movie.GenreId);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Title,ReleaseDate,RunningTime,GenreId,BoxOffice")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreName", movie.GenreId);
            return View(movie);
        }

        // GET: Movies/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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
