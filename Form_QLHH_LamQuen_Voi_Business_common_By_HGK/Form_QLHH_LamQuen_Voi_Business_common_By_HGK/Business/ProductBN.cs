using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK.Business
{
    class ProductBN
    {
        public void ThemDuLieu(Common.ProductCM p)
        {
            if (string.IsNullOrWhiteSpace(p.Name))
            {
                throw new Exception("Can phai co ten san pham!");
            }

            if (p.Price < 0 || p.Price > 100000000)
            {
                throw new Exception("Gia san pham phai >=0 va < 100tr!");
            }

            if (!p.Insert())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void ThemDuLieu(string _ten, int _gia, int _nhomhang)
        {
            Common.ProductCM p = new Common.ProductCM() { Name = _ten, Price = _gia, CateID = _nhomhang };
            //p.Insert();
            ThemDuLieu(p);
        }


        public void CapNhatDuLieu(Common.ProductCM p)
        {
            if (p.Id <= 0)
            {
                throw new Exception("Chua co Id san pham can cap nhat!");
            }

            if (string.IsNullOrWhiteSpace(p.Name))
            {
                throw new Exception("Can phai co ten san pham!");
            }

            if (p.Price < 0 || p.Price > 100000000)
            {
                throw new Exception("Gia san pham phai >=0 va < 100tr!");
            }

            if (!p.Update())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void CapNhatDuLieu(int _id, string _ten, int _gia, int _nhomhang)
        {
            Common.ProductCM p = new Common.ProductCM() { Id = _id, Name = _ten, Price = _gia, CateID = _nhomhang };
            //p.Insert();
            CapNhatDuLieu(p);
        }



        public void XoaDuLieu(Common.ProductCM p)
        {
            if (p.Id <= 0)
            {
                throw new Exception("Chua co Id san pham can cap nhat!");
            }

            if (!p.Delete())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void XoaDuLieu(int _id)
        {
            Common.ProductCM p = new Common.ProductCM() { Id = _id };
            //p.Insert();
            XoaDuLieu(p);
        }

        public List<Common.ProductCM> LayTatCaSanPham()
        {
            Common.ProductCM p = new Common.ProductCM();
            return p.GetAll();
        }
        public List<Common.ProductCM> LaySanPhamTheoCateID(int _cateID)
        {
            List<Common.ProductCM> list = LayTatCaSanPham();
            return list.Where(p => p.CateID == _cateID).ToList();
        }

        public List<Common.ProductCM> LaySanPhamTheoCateID(Common.CategoryCM c)
        {
            List<Common.ProductCM> list = LayTatCaSanPham();
            return list.Where(p => p.CateID == c.Id).ToList();
        }


    }
}
