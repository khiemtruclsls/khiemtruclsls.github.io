using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_ET_dathang_HGK.Business
{
    class BN_Cate
    {
        SimpleEntities db = new SimpleEntities();
        public int ThemMoiCategory(Category c)
        {
            c = db.Categories.Add(c);
            db.SaveChanges();
            return c.Id;
        }

        public int ThemMoiCategory(string _cateName)
        {
            return ThemMoiCategory(new Category() { Name = _cateName });
        }

        public void SuaCategory(Category c)
        {
            Category c1 = db.Categories.Find(c.Id);
            c1.Name = c.Name;
            db.Entry(c1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void SuaCategory(int _id, string _name)
        {
            SuaCategory(new Category() { Id = _id, Name = _name });
        }

        public void XoaCategory(int _id)
        {
            db.Entry(db.Categories.Find(_id)).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        public void XoaCategory(Category c)
        {
            XoaCategory(c.Id);
        }

        public List<Category> LayTatCaCategory()
        {
            return db.Categories.ToList();
        }
    }
}
