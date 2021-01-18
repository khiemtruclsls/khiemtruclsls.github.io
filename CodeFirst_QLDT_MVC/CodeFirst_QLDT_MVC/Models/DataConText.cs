using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CodeFirst_QLDT_MVC.Models
{
    public class DataConText:DbContext
    {
        public DataConText():base("QLDTDB");
        public virtual DbSet<LopHoc> DsLop { get; set; }
        public virtual DbSet<HocVien> DsHocVien { get; set; }
        public virtual DbSet<MonHoc> DsMonHoc { get; set; }
        public virtual DbSet<DiemThi> DsDiemThi { get; set; }
    }
}