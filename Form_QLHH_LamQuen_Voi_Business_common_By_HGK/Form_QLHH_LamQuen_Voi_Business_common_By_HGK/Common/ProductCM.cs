using Form_QLHH_LamQuen_Voi_Business_common_By_HGK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK.Common
{
    class ProductCM
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public int Price { get; set; }
        public int CateID { get; set; }

        public ProductCM()
        {

        }

        public ProductCM(int _id, string _name, int _price, int _cateID)
        {
            Id = _id;
            Name = _name;
            Price = _price;
            CateID = _cateID;
        }
        DataAcCess da = new DataAcCess();

        public bool Insert()
        {
            try
            {
                string sql = string.Format("INSERT INTO Product (Name,Price,CateID) VALUES ('{0}',{1},{2})", Name, Price, CateID);

                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                string sql = string.Format("Update Product SET Name='{0}',Price={1},CateID={2} WHERE Id={3}", Name, Price, CateID, Id);

                return da.ExecuteNonQueryCommad(sql) >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                string sql = string.Format("DELETE FROM Product WHERE Id={0}", Id);
                int ketqua = da.ExecuteNonQueryCommad(sql);
                return ketqua >= 0;
            }
            catch
            {
                return false;
            }
        }

        public List<ProductCM> GetAll()
        {
            string sql = "SELECT * FROM Product";
            SqlDataReader dr = da.ExecyteQuery(sql);
            List<ProductCM> list = new List<ProductCM>();
            while (dr.Read())
            {
                list.Add(new ProductCM() { Id = (int)dr["Id"], Name = (string)dr["Name"], Price = (int)dr["Price"], CateID = (int)dr["CateID"] });
            }
            return list;
        }
    }

}
