using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK.Business
{
    class CategoryBN
    {
        public void ThemDuLieu(Common.CategoryCM c)
        {
            if (string.IsNullOrWhiteSpace(c.Name))
            {
                throw new Exception("Can phai co ten san pham!");
            }
            if (!c.Inset())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void ThemDuLieu( String _Name)
        {
            Common.CategoryCM c = new Common.CategoryCM() { Name = _Name};
         
            ThemDuLieu(c);
        }
        public void CapNhatDulieu(Common.CategoryCM c)
        {
            if (c.Id <= 0)
            {
                throw new Exception("Chua co Id san pham can cap nhat!");
            }

            if (string.IsNullOrWhiteSpace(c.Name))
            {
                throw new Exception("Can phai co ten san pham!");
            }
            if (!c.update())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void CapNhatDulieu(int _Id, String _Name)
        {
            Common.CategoryCM c = new Common.CategoryCM() { Id = _Id, Name = _Name };
        
            CapNhatDulieu(c);
        }
        public void XoaDuLieu(Common.CategoryCM c)
        {
            if (c.Id <= 0)
            {
                throw new Exception("Chua co Id san pham can cap nhat!");
            }

            if (!c.detele())
                throw new Exception("Loi khi them moi du lieu!");
        }
        public void XoaDuLieu(int _id)
        {
            Common.CategoryCM c = new Common.CategoryCM() { Id = _id };
            //p.Insert();
            XoaDuLieu(c);
        }
        public List<Common.CategoryCM> LayTatCaSanPham()
        {
            Common.CategoryCM c = new Common.CategoryCM();
            return c.GetALL();
        }

    }
}
