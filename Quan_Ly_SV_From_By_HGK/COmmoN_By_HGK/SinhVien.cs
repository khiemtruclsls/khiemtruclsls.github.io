using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COmmoN_By_HGK;
using DataAccess_By_HGK;

namespace COmmoN_By_HGK
{
    public class SinhVien : CRUD<SinhVien>
    {
        public string RollNumber { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public int IdLopHoc { get; set; }

        SQLdateaccess da = new SQLdateaccess();

        public bool Delete()
        {
            if (string.IsNullOrWhiteSpace(RollNumber))
                throw new Exception("Chua co ma sinh vien can xoa!");
            string sql = string.Format("Delete FROM SinhVien WHERE RollNumber='{0}'", RollNumber);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Delete(SinhVien m)
        {
            return m.Delete();
        }

        public bool Delete(string _rollNumber)
        {
            return new SinhVien() { RollNumber = _rollNumber }.Delete();
        }

        public List<SinhVien> GetAll()
        {
            return SearchList("");
        }

        public DataTable GetAllTable()
        {
            return SearchTable(null);
        }

        public bool Insert()
        {
            if (string.IsNullOrWhiteSpace(RollNumber))
            {
                throw new Exception("Ma sinh vien khong duoc de trong!");
            }
            if (string.IsNullOrWhiteSpace(HoTen))
            {
                throw new Exception("Ho Ten khong duoc de trong!");
            }
            string sql = string.Format("Insert into SinhVien (RollNumber,HoTen,NamSinh,DiaChi,QueQuan,IdLopHoc) VALUES ('{0}','{1}',{2},'{3}','{4}',{5})", RollNumber, HoTen, NamSinh, DiaChi, QueQuan, IdLopHoc);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Insert(SinhVien m)
        {
            return m.Insert();
        }


        public bool Insert(string _rollNumber, string _hoTen, int _namSinh, string _diaChi, string _queQuan, int _idLopHoc)
        {
            return new SinhVien() { RollNumber = _rollNumber, HoTen = _hoTen, NamSinh = _namSinh, DiaChi = _diaChi, QueQuan = _queQuan, IdLopHoc = _idLopHoc }.Insert();
        }

        public List<SinhVien> SearchList(string _key)
        {
            string sql = "SELECT * FROM SinhVien";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE RollNumber like '%{0}%' OR HoTen like '%{1}%' OR DiaChi like '%{2}%'", _key, _key, _key);
            SqlDataReader dr = da.ExecuteQuery(sql);
            List<SinhVien> list = new List<SinhVien>();
            while (dr.Read())
            {
                list.Add(new SinhVien() { RollNumber = (string)dr["RollNumber"], HoTen = (string)dr["HoTen"], NamSinh = (int)dr["NamSinh"], DiaChi = (string)dr["DiaChi"], QueQuan = (string)dr["QueQuan"], IdLopHoc = (int)dr["IdLopHoc"] });
            }
            return list;
        }

        public DataTable SearchTable(string _key)
        {
            string sql = "SELECT * FROM SinhVien";
            if (!string.IsNullOrWhiteSpace(_key))
                sql = String.Format(sql + " WHERE RollNumber like '%{0}%' OR HoTen like '%{1}%' OR DiaChi like '%{2}%'", _key, _key, _key);
            DataTable tbl = da.ExecuteQueryTable(sql);
            return tbl;
        }

        public bool Update()
        {
            if (string.IsNullOrWhiteSpace(RollNumber))
            {
                throw new Exception("Ma sinh vien khong duoc de trong!");
            }
            if (string.IsNullOrWhiteSpace(HoTen))
            {
                throw new Exception("Ho Ten khong duoc de trong!");
            }
            string sql = string.Format("Update SinhVien SET HoTen='{0}',NamSinh={1},DiaChi='{2}',QueQuan='{3}',IdLopHoc={4} WHERE RollNumber='{5}'", HoTen, NamSinh, DiaChi, QueQuan, IdLopHoc, RollNumber);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Update(SinhVien m)
        {
            return m.Update();
        }

        public bool Update(string _rollNumber, string _hoTen, int _namSinh, string _diaChi, string _queQuan, int _idLopHoc)
        {
            return new SinhVien() { RollNumber = _rollNumber, HoTen = _hoTen, NamSinh = _namSinh, DiaChi = _diaChi, QueQuan = _queQuan, IdLopHoc = _idLopHoc }.Update();
        }
    }
}
