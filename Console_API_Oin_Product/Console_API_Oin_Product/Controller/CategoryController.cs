using Console_API_Oin_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Console_API_Oin_Product.Controller
{
    public class CategoryController : ApiController
    {
        ProductMNGEntities2 db = new ProductMNGEntities2();
        public IHttpActionResult Get()
        {
            return Ok(db.Categories);
        }
        public IHttpActionResult Get(int id)
        {
            if (id < 0) return NotFound();
            var c = db.Categories.Find(id);
            if (c == null) return NotFound();
            return Ok(c);
        }
        public IHttpActionResult Post(Category c)
        {
            if (c == null) return NotFound();
            db.Categories.Add(c);
            db.SaveChanges();
            return Ok("add Success!");
        }
        public IHttpActionResult Put(Category c)
        {
            if (c == null) return NotFound();
            db.Entry(c).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok("Edit success!");
        }
        public IHttpActionResult Detele(int id)
        {
            if (id <= 0) return NotFound();
            var c = db.Categories.Find(id);
            if (c == null) return NotFound();
            db.Categories.Remove(c);
            db.SaveChanges();
            return Ok("Detele Succes!");
        }
    }

}

