using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_QLDT_MVC.Models
{
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150,MinimumLength = 2)]
        public string TenLop { get; set; }
        [Required]
        [Range(1900,2100)]
        public int NamBatDau { get; set; }
        public virtual ICollection<HocVien> HocVienCuaLop { get; set; }
    }
}