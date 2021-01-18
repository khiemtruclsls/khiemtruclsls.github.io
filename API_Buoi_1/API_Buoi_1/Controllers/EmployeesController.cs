using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using API_Buoi_1.Models;

namespace API_Buoi_1.Controllers
{
    public class EmployeesController : Controller
    {


        // GET: Employees
        public ActionResult Index()
        {
           
            return View();
        }

    } 
}
