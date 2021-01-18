using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Console_Owin.Model;

namespace Console_Owin.Controllers
{
   
    public class MoviesController:ApiController
    {
        DbMoviesEntities db = new DbMoviesEntities();

        public IHttpActionResult Get()
        {
            return Ok(db.Movies);
        }
        public IHttpActionResult Get(int id)
        {
            if (id < 0) return NotFound();
            var m = db.Movies.Find(id);
            if (m == null) return NotFound();
            return Ok(m);
        }
        public IHttpActionResult Post(Movie m)
        {
            if (m == null) return NotFound();
            db.Movies.Add(m);
            db.SaveChanges();
            return Ok("add Success!");
        }
        public IHttpActionResult Put(Movie m)
        {
            if (m == null) return NotFound();
            db.Entry(m).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok("Edit success!");
        }
        public IHttpActionResult Detele(int id)
        {
            if (id <= 0) return NotFound();
            var m = db.Movies.Find(id);
            if (m == null) return NotFound();
            db.Movies.Remove(m);
            db.SaveChanges();
            return Ok("Detele Succes!");
        }
    }
}
