using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quan_Ly_SV.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Tên Học Sinh")]
        [StringLength(150,MinimumLength = 2)]
        public string StudentName { get; set; }
        [Display(Name ="Mã Sinh Viên")]
        [Required]
        public string StudentRollId { get; set; }
        [Display(Name = "Ngày Sinh")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StudentDOB { get; set; }
        [Display(Name = "Mã Lớp")]
        [Required]
        public int ClassID { get; set; }
        public virtual ICollection<Exam> StudentExam { get; set; }
    }
}
