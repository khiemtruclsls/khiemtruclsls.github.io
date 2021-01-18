using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_QLDT_MVC.Models
{
    public class HocVien
    {   [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150,MinimumLength =3)]
        public string HoTen { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgaySinh { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20,MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        public string SDT { get; set; }
        [ForeignKey("LopCuaHocVien")]
        public int IdLopHoc { get; set; }
        public virtual LopHoc LopCuaHocVien { get; set; }
        public virtual ICollection<DiemThi> KetQuaCuaHocVien { get; set; }
    }
}