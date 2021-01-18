using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_QLSVV.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.DsSubject.Add(new SubjectS() { SubjectName = "java", SubjectId = 1 });
            context.DsSubject.AddRange(new List<SubjectS>(){
                new SubjectS() { SubjectName = "C#"},
                new SubjectS() { SubjectName = "Html"}
            });
            context.DsStudent.Add(new Student() { StudentID = 1, StudentName = "Khiêm", StudentRoll = "CC20HK", StudentDOB = new DateTime(2000, 10, 10), ClassID = 1 });
            context.DsStudent.AddRange(new List<Student>() {
                new Student() {StudentName = "Dat", StudentRoll = "CC30HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                 new Student() {StudentName = "Anh", StudentRoll = "CC40HK" , StudentDOB = new DateTime(1996, 11, 10) ,ClassID = 1 },
                  new Student() {StudentName = "Manh", StudentRoll = "CC50HK" , StudentDOB = new DateTime(1993, 11, 10) ,ClassID = 1 },
                   new Student() {StudentName = "Cuong", StudentRoll = "C630HK" , StudentDOB = new DateTime(1992, 11, 10) ,ClassID = 1 },
                    new Student() {StudentName = "Tu", StudentRoll = "CC70HK" , StudentDOB = new DateTime(1991, 11, 10) ,ClassID = 1 },
                     new Student() {StudentName = "Long", StudentRoll = "CC80HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                      new Student() {StudentName = "hai", StudentRoll = "CC90HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                       new Student() {StudentName = "Thang", StudentRoll = "CC00HK" , StudentDOB = new DateTime(1990, 11, 10) ,ClassID = 1 },
                        new Student() {StudentName = "Hoat", StudentRoll = "CC21HK" , StudentDOB = new DateTime(1999, 11, 10) ,ClassID = 1 }

             });
            context.DsExam.Add(new Exam() { StudentID = 1, SubjectID = 1, Mark = 30 });
           
            context.SaveChanges();
            base.Seed(context);
        }
    }
}