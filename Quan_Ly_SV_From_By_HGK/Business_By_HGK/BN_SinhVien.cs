using System;
using COmmoN_By_HGK;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_By_HGK
{
   public class BN_SinhVien
    {
        public bool ThemMoiSinhVien(string _rollNumber, string _hoTen, int _namSinh, string _diaChi, string _queQuan, int _idLopHoc)
        {
            SinhVien m = new SinhVien() { RollNumber = _rollNumber, HoTen = _hoTen, NamSinh = _namSinh, DiaChi = _diaChi, QueQuan = _queQuan, IdLopHoc = _idLopHoc };
            return m.Insert();
        }

        public bool SuaSinhVien(string _rollNumber, string _hoTen, int _namSinh, string _diaChi, string _queQuan, int _idLopHoc)
        {
            SinhVien m = new SinhVien() { RollNumber = _rollNumber, HoTen = _hoTen, NamSinh = _namSinh, DiaChi = _diaChi, QueQuan = _queQuan, IdLopHoc = _idLopHoc };
            return m.Update();
        }

        public bool XoaSinhVien(string _rollNumber)
        {
            return new SinhVien().Delete(_rollNumber);
        }

        public List<SinhVien> LayTatCaSinhVien()
        {
            return new SinhVien().GetAll();
        }

        public DataTable LayTatCaSinhVienTable()
        {
            return new SinhVien().GetAllTable();
        }


        public List<SinhVien> TimSinhVien(string _key)
        {
            return new SinhVien().SearchList(_key);
        }

        public DataTable TimSinhVienTable(string _key)
        {
            return new SinhVien().SearchTable(_key);
        }
    }
}
