﻿//------------------------------------------------------------------------------
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

    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            this.HocViens = new HashSet<HocVien>();
        }
    
        public int Id { get; set; }
        [Required]
        [Display(Name = "Lớp Học ")]
        public string LopHoc1 { get; set; }
        [Required]
        [Range(1900, 2100,ErrorMessage = "Dữ liệu năm bắt đầu từ {0} đến {1}")]
        [Display(Name = "Năm Bắt Đầu ")]
        public Nullable<int> NamBatDau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocVien> HocViens { get; set; }
    }
}