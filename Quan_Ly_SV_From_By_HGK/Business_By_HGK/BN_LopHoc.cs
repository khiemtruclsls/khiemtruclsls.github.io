using COmmoN_By_HGK;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_By_HGK
{
     public class BN_LopHoc 
    {
        public bool TheMoiLopHoc(string _tenLop)
        {
            LopHoc l = new LopHoc() { TenLop = _tenLop };
            return l.Insert();
        }

        public bool SuaLopHoc(int _id, string _tenLop)
        {
            return new LopHoc().Update(_id, _tenLop);
        }

        public bool XoaLopHoc(int _id)
        {
            return new LopHoc().Delete(_id);
        }

        public List<LopHoc> LayTatCaLopHoc()
        {
            return new LopHoc().GetAll();
        }

        public DataTable LayTatCaLopHocTable()
        {
            return new LopHoc().GetAllTable();
        }


        public List<LopHoc> TimLopHoc(string _key)
        {
            return new LopHoc().SearchList(_key);
        }

        public DataTable TimLopHocTable(string _key)
        {
            return new LopHoc().SearchTable(_key);
        }
    }
}
