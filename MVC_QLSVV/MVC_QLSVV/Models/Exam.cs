using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_QLSVV.Models
{
    public class Exam
    {   [Key,Column(Order = 1)]
        [ForeignKey("LopHoc")]
        public int SubjectID { get; set; }
        [Key,Column(Order = 2)]
        [ForeignKey("HocVien")]
        public int StudentID { get; set; }
        [Required]
        [Range(1,100)]
        public int Mark { get; set; }
        public virtual SubjectS LopHoc { get; set; }
        public virtual Student HocVien { get; set; }
    }
}