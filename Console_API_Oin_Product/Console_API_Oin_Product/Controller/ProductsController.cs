using Console_API_Oin_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Console_API_Oin_Product.Controller
{
        public class ProductsController : ApiController
        {
        ProductMNGEntities2 db = new ProductMNGEntities2();
        public IHttpActionResult Get()
        {
            return Ok(db.Products);
        }
        public IHttpActionResult Get(int id)
        {
            if (id < 0) return NotFound();
            var p = db.Products.Find(id);
            if (p == null) return NotFound();
            return Ok(p);
        }
        public IHttpActionResult Post(Product p)
        {
            if (p == null) return NotFound();
            db.Products.Add(p);
            db.SaveChanges();
            return Ok("add Success!");
        }
        public IHttpActionResult Put(Product p)
        {
            if (p == null) return NotFound();
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok("Edit success!");
        }
        public IHttpActionResult Detele(int id)
        {
            if (id <= 0) return NotFound();
            var p = db.Products.Find(id);
            if (p == null) return NotFound();
            db.Products.Remove(p);
            db.SaveChanges();
            return Ok("Detele Succes!");
        }
    }


    
}
