using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quan_Ly_SV.Models
{
    public class Subject
    {   [Key]
        public int SubjectID { get; set; }
        [Required]
        [Display(Name = "Tên Lớp" )]
        [StringLength(30,MinimumLength = 1)]
        public string SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }
}