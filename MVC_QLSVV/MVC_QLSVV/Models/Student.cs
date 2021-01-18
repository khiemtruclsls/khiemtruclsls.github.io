using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_QLSVV.Models
{
    public class Student
    {   [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 2)]
        [Display(Name = "Tên Học Sinh")]
        public string StudentName { get; set; }
        [Required]
        [Display(Name = "Mã sinh viên")]
        public string StudentRoll { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh ")]
        
        public DateTime StudentDOB { get; set; }
        [Display(Name = "Mã Lớp")]
        [Required]
        public  int ClassID { get; set; }
        public virtual ICollection<Exam> Examstudent { get; set; }
    }
}