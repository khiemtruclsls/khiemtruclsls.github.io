//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Diem_Thi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocVien()
        {
            this.DiemThis = new HashSet<DiemThi>();
        }
    
        public int Id { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime NgaySinh { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string SoDT { get; set; }
        public int IdLopHoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemThi> DiemThis { get; set; }
        public virtual LopHoc LopHoc { get; set; }
    }
}