using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_QLDT_MVC.Models
{
    public class DiemThi
    {   [Key,Column(Order = 1)]
        [ForeignKey("HocVienThi")]
        public int IdHocVien { get; set; }
        [Key, Column(Order = 2)]
        [ForeignKey("MonHocThi")]
        public int IdMonHoc { get; set; }
        [Key, Column(Order = 3)]
        [Required]
        [Range(1,10)]
        public int Lanthi { get; set; }
        [Required]
        [Range(0,100)]
        public int KetQuaThi { get; set; }
        public virtual HocVien HocVienThi { get; set; }
        public virtual MonHoc MonHocThi { get; set; }
    }
}