using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using Employee_Registration.Controllers;
using Employee_Registration.Models;
using System.Configuration;

namespace Employee_Registration.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
            [HttpPost]
        public ActionResult Register (Homepage emp)
        {
            {
                if (ModelState.IsValid)
                {
                    DatabaseHandler ItemHandler = new DatabaseHandler();
                    if (ItemHandler.createdata(emp))
                    {
                        ViewBag.Message = "Item Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
        }
       
    }
}