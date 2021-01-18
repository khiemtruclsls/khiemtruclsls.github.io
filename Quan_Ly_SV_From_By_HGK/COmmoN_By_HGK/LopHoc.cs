using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_By_HGK;
using System.Data;
using System.Data.SqlClient;


namespace COmmoN_By_HGK
{
    public class LopHoc : CRUD<LopHoc>
    {
        public int Id { get; set; }
        public string TenLop { get; set; }

        SQLdateaccess da = new SQLdateaccess();
        public bool Insert()
        {

            if (string.IsNullOrWhiteSpace(TenLop))
            {
                throw new Exception("Ten Lop khong duoc de trong!");
            }
            string sql = string.Format("Insert into LopHoc (Code) VALUES ('{0}')", TenLop);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Insert(LopHoc m)
        {
            return m.Insert();
        }
        public bool Insert(string _tenLop)
        {
            return Insert(new LopHoc() { TenLop = _tenLop });
        }


        public bool Update()
        {
            if (string.IsNullOrWhiteSpace(TenLop))
            {
                throw new Exception("Ten Lop khong duoc de trong!");
            }
            if (Id <= 0)
                throw new Exception("Chua co Id lop can sua!");
            string sql = string.Format("Update LopHoc SET Code='{0}' WHERE Id={1}", TenLop, Id);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Update(LopHoc m)
        {
            return m.Update();
        }
        public bool Update(int _id, string _tenLop)
        {
            return Update(new LopHoc() { Id = _id, TenLop = _tenLop });
        }

        public bool Delete()
        {
            if (Id <= 0)
                throw new Exception("Chua co Id mon can sua!");
            string sql = string.Format("Delete FROM LopHoc WHERE Id={0}", Id);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Delete(LopHoc m)
        {
            return m.Update();
        }
        public bool Delete(int _id)
        {
            return Delete(new LopHoc() { Id = _id });
        }

        public List<LopHoc> GetAll()
        {
            return SearchList("");
        }

        public DataTable GetAllTable()
        {
            return SearchTable(null);
        }

        public DataTable SearchTable(string _key)
        {
            string sql = "SELECT * FROM LopHoc";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE Code like '%{0}%'", _key);
            DataTable tbl = da.ExecuteQueryTable(sql);
            return tbl;
        }

        public List<LopHoc> SearchList(string _key)
        {
            string sql = "SELECT * FROM LopHoc";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE Code like '%{0}%'", _key);
            SqlDataReader dr = da.ExecuteQuery(sql);
            List<LopHoc> list = new List<LopHoc>();
            while (dr.Read())
            {
                list.Add(new LopHoc() { Id = (int)dr["Id"], TenLop = (string)dr["Code"] });
            }
            return list;
        }
    }
}
