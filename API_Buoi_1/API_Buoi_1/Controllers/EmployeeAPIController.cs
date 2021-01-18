using API_Buoi_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Buoi_1.Controllers
{
    public class EmployeeAPIController : ApiController
    {
        Models.EmployeeDBEntities db = new Models.EmployeeDBEntities();
        
        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }
        public IHttpActionResult Get(string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                return Ok(db.Employees.Where(e => e.EmployeeName.Contains(keyword) || e.EmployeeEmail.Contains(keyword) || e.EmployeeAddress.Contains(keyword)).ToList());
            }
            else return NotFound();
        }
        public IHttpActionResult Get(int id )
        {
            if (id <= 0) return NotFound();
            var emp = db.Employees.Find(id);

            if(emp != null && emp.EmployeeId > 0)
            {
                return Ok(emp);
            }
            else
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post(Employee emp)
        {
            if (emp != null || string.IsNullOrEmpty(emp.EmployeeName)) return NotFound();
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok("Them moi nhan vien thanh cong");
        }
        public IHttpActionResult Put(Employee emp)
        {
            if (emp != null || string.IsNullOrEmpty(emp.EmployeeName)) return NotFound();
            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok("Sua moi nhan vien thanh cong");
        }
        public IHttpActionResult Detele(int id)
        {
            if (id <= 0)
            {
                return NotFound();

            }
            var emp = db.Employees.Find(id);
            if (emp != null && emp.EmployeeId > 0)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                return Ok("Xoa nhan vien thanh cong");
            }
            else return NotFound();
        }

    }
}
