using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quan_Ly_SV.Models
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.DsSubject.Add(new Subject() { SubjectName = "C1907L", SubjectID = 1 });
            context.DsSubject.AddRange(new List<Subject>(){
                new Subject() { SubjectName = "C2020"},
                new Subject() { SubjectName = "C2021"}
            });
            context.DsStudent.Add(new Student() {StudentId = 1 , StudentName = "Khiêm", StudentRollId = "CC20HK" , StudentDOB = new DateTime(2000, 10, 10) ,ClassID = 1 });
            context.DsStudent.AddRange(new List<Student>() { 
                new Student() {StudentName = "Dat", StudentRollId = "CC30HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                 new Student() {StudentName = "Anh", StudentRollId = "CC40HK" , StudentDOB = new DateTime(1996, 11, 10) ,ClassID = 1 },
                  new Student() {StudentName = "Manh", StudentRollId = "CC50HK" , StudentDOB = new DateTime(1993, 11, 10) ,ClassID = 1 },
                   new Student() {StudentName = "Cuong", StudentRollId = "C630HK" , StudentDOB = new DateTime(1992, 11, 10) ,ClassID = 1 },
                    new Student() {StudentName = "Tu", StudentRollId = "CC70HK" , StudentDOB = new DateTime(1991, 11, 10) ,ClassID = 1 },
                     new Student() {StudentName = "Long", StudentRollId = "CC80HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                      new Student() {StudentName = "hai", StudentRollId = "CC90HK" , StudentDOB = new DateTime(1997, 11, 10) ,ClassID = 1 },
                       new Student() {StudentName = "Thang", StudentRollId = "CC00HK" , StudentDOB = new DateTime(1990, 11, 10) ,ClassID = 1 },
                        new Student() {StudentName = "Hoat", StudentRollId = "CC21HK" , StudentDOB = new DateTime(1999, 11, 10) ,ClassID = 1 }

             });
            context.DsExam.Add(new Exam() { StudentId = 1, SubjectId = 1 , Mark = 30 });
            context.DsExam.Add(new Exam() { StudentId = 2, SubjectId = 1, Mark = 30 });
            context.DsExam.Add(new Exam() { StudentId = 3, SubjectId = 1, Mark = 40 });
            context.DsExam.Add(new Exam() { StudentId = 4, SubjectId = 1, Mark = 50 });
            context.DsExam.Add(new Exam() { StudentId = 5, SubjectId = 1, Mark = 60 });
            context.DsExam.Add(new Exam() { StudentId = 1, SubjectId = 1, Mark = 50 });
            context.DsExam.Add(new Exam() { StudentId = 2, SubjectId = 1, Mark = 80 });
            context.DsExam.Add(new Exam() { StudentId = 3, SubjectId = 1, Mark = 90 });
            context.DsExam.Add(new Exam() { StudentId = 4, SubjectId = 1, Mark = 20 });
            context.DsExam.Add(new Exam() { StudentId = 5, SubjectId = 1, Mark = 40 });
            context.DsExam.Add(new Exam() { StudentId = 6, SubjectId = 2, Mark = 70 });
            context.DsExam.Add(new Exam() { StudentId = 7, SubjectId = 2, Mark = 80 });
            context.DsExam.Add(new Exam() { StudentId = 8, SubjectId = 2, Mark = 30 });
            context.DsExam.Add(new Exam() { StudentId = 9, SubjectId = 2, Mark = 40 });
            context.DsExam.Add(new Exam() { StudentId = 10, SubjectId = 2, Mark = 20 });
            context.DsExam.Add(new Exam() { StudentId = 6, SubjectId = 2, Mark = 10 });
            context.DsExam.Add(new Exam() { StudentId = 7, SubjectId = 2, Mark = 50 });
            context.DsExam.Add(new Exam() { StudentId = 8, SubjectId = 2, Mark = 15 });
            context.DsExam.Add(new Exam() { StudentId = 9, SubjectId = 2, Mark = 35 });
            context.DsExam.Add(new Exam() { StudentId = 10, SubjectId = 2, Mark = 55 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}