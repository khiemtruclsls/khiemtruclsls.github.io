using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_QLSVV.Models
{
    public class SubjectS
    {   [Key]
        public int SubjectId { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 1)]
        public string SubjectName { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}