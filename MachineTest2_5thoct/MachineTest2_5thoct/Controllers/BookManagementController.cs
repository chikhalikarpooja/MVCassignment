using MachineTest2_5thoct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MachineTest2_5thoct.Controllers
{
    public class BookManagementController : Controller
    {
        // GET: BookManagement
        public ActionResult Index()
        {
            ViewBag.student = "Book Details";
       DatabaseHandler dataBaseHandler = new DatabaseHandler();
            ModelState.Clear();

            return View(dataBaseHandler.GetItemList());
          
        }
        [HttpGet]  // http get use to get values from user
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Homepage iList)
        {


            {
                if (ModelState.IsValid)
                {
                    DatabaseHandler ItemHandler = new DatabaseHandler();
                    if (ItemHandler.Insert_Item(iList))
                    {
                        ViewBag.Message = "Item Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login ls)

        {
             string constrings = ConfigurationManager.ConnectionStrings["constring"].ToString();
            SqlConnection con = new SqlConnection(constrings);
            string qr = "select email , password from User_RegBook where email=@email and password = @password";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@email", ls.email_id);
            cmd.Parameters.AddWithValue("@password", ls.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["email"] = ls.email_id.ToString();
                return RedirectToAction("Welcome");
            }
            else
            {
                ViewData["Message"] = "User Login Failed";
            }
            con.Close();
            return View();
        }
        public ActionResult Welcome()
        {
                       return View();
        }
        public ActionResult logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }

        [HttpGet]  // http get use to get values from user
        public ActionResult BookAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookAdd(AddBook iList1)
        {


            {
                if (ModelState.IsValid)
                {
                    DatabaseHandler ItemHandler = new DatabaseHandler();
                    if (ItemHandler.Insert_Book(iList1))
                    {
                        ViewBag.Message = "Item Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }

        }
        [HttpGet]
        public ActionResult update(string email)
        {
DatabaseHandler dataBaseHandler = new DatabaseHandler();
            return View(dataBaseHandler.GetItemList().Find(AddBook => AddBook.BookName== email));
        }
        [HttpPost]
        public ActionResult update(string BookName, AddBook updata)
        {

            try
            {

              DatabaseHandler ItemHandler1 = new DatabaseHandler();
                ItemHandler1.updatelist(updata);

                //ModelState.Clear();
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

    }
}