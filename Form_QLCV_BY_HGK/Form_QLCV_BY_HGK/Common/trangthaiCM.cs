using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Form_QLCV_BY_HGK
{
    class trangthaiCM
    {
        public int ID_tt { get; set; }
        public string Name_tt { get; set; }



        public trangthaiCM()
        {
        }
        public trangthaiCM(int id, string name)
        {
            ID_tt = id;
            Name_tt = name;
        }
        DataAccess da = new DataAccess();
        public List<trangthaiCM> GetALL()
        {
            String sql = "SELECT * FROM trangthai";
            SqlDataReader dr = da.ExecyteQuery(sql);
            List<trangthaiCM> list = new List<trangthaiCM>();
            while (dr.Read())
            {
                list.Add(new trangthaiCM() { ID_tt = (int)dr["ID_tt"], Name_tt = (string)dr["Name_tt"] });
            }
            return list;
        }
    }
}
