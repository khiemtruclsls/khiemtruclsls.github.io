using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_QLDT_MVC.Models
{
    public class MonHoc
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 5)]
        [Display(Name = "Tên Môn")]
        public string TenMon { get; set; }
        [Required]
        [Display(Name ="Viết Tắt ")]
        [StringLength(10,MinimumLength = 2)]
        public string VietTat { get; set; }
        public virtual ICollection<DiemThi> CacDiemThiCuaMon { get; set; }
    }
}