using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Form_QLHH_LamQuen_Voi_Business_common_By_HGK.DataAccess;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK.Common
{
    class CategoryCM
    {
        public int Id { get; set; }
        public string Name { get; set; }


       
        public CategoryCM()
        {
        }
        public CategoryCM(int id, string name)
        {
            Id = id;
            Name = name;
        }
        DataAcCess da = new  DataAcCess();
        public bool Inset()
        {
            try{
                String sql = String.Format("INSERT INTO Category (Name) VALUES ('{0}')",Name);
                return da.ExecuteNonQueryCommad(sql)>= 0 ;
                }
            catch
            {
                return false;
            }
        }
        public bool update()
        {
            try
            {
                string sql = string.Format("UPDATE Category SET Name = '{0}' WHERE Id = {1} ", Name, Id);
                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool detele()
        {
            try
            {
                string sql = string.Format("DELETE FROM Category WHERE Id = {0} ", Id);
                int ketqua = da.ExecuteNonQueryCommad(sql);
                return ketqua >= 0;
            }
            catch
            {
                return false;
            }

        }
        public List<CategoryCM> GetALL()
        {
            String sql = "SELECT * FROM Category";
            SqlDataReader dr = da.ExecyteQuery(sql);
            List<CategoryCM> list = new List<CategoryCM>();
            while (dr.Read())
            {
                list.Add(new CategoryCM() { Id = (int)dr["Id"], Name = (string)dr["Name"] });
            }
            return list;
        }
    }
}
