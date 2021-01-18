using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_QLSVV.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("QLSVS")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DataInitializer());
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> DsStudent { get; set; }
        public virtual DbSet<SubjectS> DsSubject { get; set; }
        public virtual DbSet<Exam> DsExam { get; set; }
    }
}