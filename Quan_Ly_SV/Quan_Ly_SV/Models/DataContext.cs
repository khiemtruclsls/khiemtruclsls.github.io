using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quan_Ly_SV.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("Quan_ly_SVien")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DataInitializer());
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> DsStudent { get; set; }
        public virtual DbSet<Subject> DsSubject { get; set; }
        public virtual DbSet<Exam> DsExam { get; set; }
    }
}