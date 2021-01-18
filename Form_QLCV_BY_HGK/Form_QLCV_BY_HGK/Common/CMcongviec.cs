 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLCV_BY_HGK.Common
{
    class CMcongviec
    {
        public int ID_Cv { get; set; }
        public DateTime ngaytao { get; set; }
        public int ID_TT { get; set; }

        public DateTime ngayhoanthanh { get; set; }
        public String Noidung { get; set; }
        public CMcongviec()
        {

        }

        public CMcongviec( int _ID_Cv,DateTime _ngaytao, int _ID_TT, DateTime _ngayhoanthanh, String _Noidung)
        {
            ID_Cv = _ID_Cv; 
            ngaytao = _ngaytao;
            ID_TT = _ID_TT;
            ngayhoanthanh = _ngayhoanthanh;
            Noidung = _Noidung;
        }
        DataAccess da = new DataAccess();
        public bool Insert()
        {
            try
            {
                string sql = string.Format("INSERT INTO congviec (ngaytao,ID_TT,ngayhoanthanh,Noidung) VALUES ('{0}','{1}','{2}','{3}')", ngaytao, ID_TT, ngayhoanthanh, Noidung);

                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Update()
        {
            try {
                string sql = string.Format("Update congviec SET ngaytao = '{0}' , ID_TT = '{1}' , ngayhoanthanh = '{2}', Noidung = '{3}' WHERE ID_Cv = '{4}'", ngaytao, ID_TT, ngayhoanthanh, Noidung ,ID_Cv);
                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool delete()
        {
            try {
                string sql = string.Format("Delete From congviec WHERE ID_Cv = {0}",ID_Cv);
                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
      
        public List<CMcongviec> GetALL()
        {
            String sql = "SELECT * FROM congviec";
            SqlDataReader dr = da.ExecyteQuery(sql);
            List<CMcongviec> list = new List<CMcongviec>();
            while(dr.Read())
            {
                list.Add(new CMcongviec() { ID_Cv = (int)dr["ID_Cv"],ngaytao = (DateTime)dr["ngaytao"],ID_TT = (int)dr["ID_TT"], ngayhoanthanh = (DateTime)dr["ngayhoanthanh"],Noidung = (string)dr["Noidung"] });
            }
            return list;
        }
    }
}
