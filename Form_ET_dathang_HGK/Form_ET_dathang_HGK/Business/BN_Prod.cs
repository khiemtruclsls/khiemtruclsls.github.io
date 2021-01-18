using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_ET_dathang_HGK.Business
{
    class BN_Prod
    {
        SimpleEntities db = new SimpleEntities();
        public int themmoidulieu(Product p)
        {
            p = db.Products.Add(p);
            db.SaveChanges();
            return p.Id;
        }
        public int themmoidulieu(String _Name , int _Price , int _CateId)
        {
            return themmoidulieu(new Product() { Name = _Name, Price = _Price, CateId = _CateId });
        }
        public void SuaProdut(Product p)
        {
            Product p1 = db.Products.Find(p.Id);
            p1.Name = p.Name;
            p1.Price = p.Price;
            p1.CateId = p.CateId;
            db.Entry(p1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void SuaProdut(int _id , string _Name , int _Price , int _CateId)
        {
            SuaProdut(new Product() { Id = _id, Name = _Name, Price = _Price, CateId = _CateId });
        }
        public void xoadl( int _id)
        {
            db.Entry(db.Products.Find(_id)).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        public void xoadl(Product p)
        {
            xoadl(p.Id);
        }
        public List<Product> laytatcaProduct()
        {
            return db.Products.ToList();
        }
    }
}
