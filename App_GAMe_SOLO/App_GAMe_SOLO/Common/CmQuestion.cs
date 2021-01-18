using System;
using App_GAMe_SOLO.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_GAMe_SOLO.Common
{
     public class CmQuestion
    {

        public int Id { get; set; }
        public string Cau_Hoi { get; set; }
        public int diem { get; set; }
        
        public bool nhieudapan { get; set; }


       Dataaccess  da = new Dataaccess();
        public CmQuestion()
        {

        }
        public CmQuestion(int _id, string _Cau_Hoi, int _diem, bool _nhieudapan)
        {
            Id = _id;
            Cau_Hoi = _Cau_Hoi;
            diem = _diem;
            nhieudapan = _nhieudapan;
        }
        public bool Inset()
        {
            try {
                string sql = string.Format("Insert into Question  ( Cau_Hoi , Diem , Nhieu_dap_an) values ('{0}' ,'{1}', '{2}' ) ", Cau_Hoi , diem , nhieudapan);
                return da.ExecuteNonQueryCommad(sql) >=  0;
            }
            catch
            {
                return false;
            } 
        }
        public bool update()
        {
            try {
                string sql = string.Format("update Question set Cau_Hoi  = '{0}' , Diem = '{1} , Nhieu_dap_an = '{2}' where Id_QT  = '{3}'", Cau_Hoi , diem,nhieudapan,Id);
                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch {

                return false;
            }

        }   
        public bool delete()
        {
            try
            {
                string sql = string.Format("detele from Question Where Id_QT = '{0}'", Id);
                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public List<CmQuestion> GetALl()
        {
       
                string sql = "Select * from Question ";
                SqlDataReader dr = da.ExecyteQuery(sql);
                List<CmQuestion> list = new List<CmQuestion>();
                while (dr.Read())
                {
                    list.Add(new CmQuestion() { Id = (int)dr["Id_QT"], Cau_Hoi = (String)dr["Cau_Hoi"], diem = (int)dr["Diem"], nhieudapan = (bool)dr["Nhieu_dap_an"] });
                }
                return list; 
         
        }

    }
}
