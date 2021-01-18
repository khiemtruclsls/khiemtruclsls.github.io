using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COmmoN_By_HGK;
using System.Data;

namespace Business_By_HGK
{
    public class BN_MonHoc
    {
        public bool ThemMoiMonHoc(string _maMon, string _tenMon)
        {
            MOnHOc m = new MOnHOc() { MaMon = _maMon, TenMon = _tenMon };
            return m.Insert();
        }

        public bool SuaMonHoc(int _id, string _maMon, string _tenMon)
        {
            MOnHOc m = new MOnHOc() { Id = _id, MaMon = _maMon, TenMon = _tenMon };
            return m.Update();
        }

        public bool XoaMonHoc(int _id)
        {
            return new MOnHOc().Delete(_id);
        }

        public List<MOnHOc> LayTatCaMonHoc()
        {
            return new MOnHOc().GetAll();
        }

        public DataTable LayTatCaMonHocTable()
        {
            return new MOnHOc().GetAllTable();
        }


        public List<MOnHOc> TimMonHoc(string _key)
        {
            return new MOnHOc().SearchList(_key);
        }

        public DataTable TimMonHocTable(string _key)
        {
            return new MOnHOc().SearchTable(_key);
        }
    }
}
