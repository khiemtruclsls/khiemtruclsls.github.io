using DataAccess_By_HGK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace COmmoN_By_HGK
{
   public class MOnHOc : CRUD<MOnHOc>
    {
        public int Id { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }

        SQLdateaccess da = new SQLdateaccess();

        public bool Insert()
        {

            if (string.IsNullOrWhiteSpace(MaMon))
            {
                throw new Exception("Ma mon khong duoc de trong!");
            }
            if (string.IsNullOrWhiteSpace(TenMon))
            {
                throw new Exception("Ten mon khong duoc de trong!");
            }
            string sql = string.Format("Insert into MonHoc (MaMon,TenMon) VALUES ('{0}','{1}')", MaMon, TenMon);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Insert(MOnHOc m)
        {
            return m.Insert();
        }
        public bool Insert(string _maMon, string _tenMon)
        {
            return Insert(new MOnHOc() { MaMon = _maMon, TenMon = _tenMon });
        }


        public bool Update()
        {
            if (string.IsNullOrWhiteSpace(MaMon))
            {
                throw new Exception("Ma mon khong duoc de trong!");
            }
            if (string.IsNullOrWhiteSpace(TenMon))
            {
                throw new Exception("Ten mon khong duoc de trong!");
            }
            if (Id <= 0)
                throw new Exception("Chua co Id mon can sua!");
             string sql = string.Format("Update MonHoc SET MaMon='{0}',TenMon={1} WHERE Id={2}", MaMon, TenMon, Id);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Update(MOnHOc m)
        {
            return m.Update();
        }
        public bool Update(int _id, string _maMon, string _tenMon)
        {
            return Update(new MOnHOc() { Id = _id, MaMon = _maMon, TenMon = _tenMon });
        }

        public bool Delete()
        {
            if (Id <= 0)
                throw new Exception("Chua co Id mon can sua!");
            string sql = string.Format("Delete FROM MonHoc WHERE Id={0}", Id);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Delete(MOnHOc m)
        {
            return m.Update();
        }
        public bool Delete(int _id)
        {
            return Delete(new MOnHOc() { Id = _id });
        }

        public List<MOnHOc> GetAll()
        {
            return SearchList("");
        }

        public DataTable GetAllTable()
        {
            return SearchTable(null);
        }

        public DataTable SearchTable(string _key)
        {
            string sql = "SELECT * FROM MonHoc";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE MaMon like '%{0}%' OR TenMon like '%{1}%'", _key, _key);
            DataTable tbl = da.ExecuteQueryTable(sql);
            return tbl;
        }

        public List<MOnHOc> SearchList(string _key)
        {
            string sql = "SELECT * FROM MonHoc";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE MaMon like '%{0}%' OR TenMon like '%{1}%'", _key, _key);
            SqlDataReader dr = da.ExecuteQuery(sql);
            List<MOnHOc> list = new List<MOnHOc>();
            while (dr.Read())
            {
                list.Add(new MOnHOc() { Id = (int)dr["Id"], MaMon = (string)dr["MaMon"], TenMon = (string)dr["TenMon"] });
                
            }
            return list;
        }
    }
}
