using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quan_Ly_SV.Models
{
    public class Exam
    {
        [Key,Column(Order = 1)]
        [ForeignKey("SubjectE")]
        public int SubjectId { get; set; }
        [ForeignKey("StudentE")]
        [Key,Column(Order = 2)]
        public int StudentId { get; set; }
        [Required]
        [Range(1,100)]  
        public int Mark { get; set; }

        public virtual Subject SubjectE { get; set; }
        public virtual Student StudentE  { get; set; }
    }
}