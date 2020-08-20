using Student_RegistrationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

//in controller we can create multiple method 
namespace Student_RegistrationMVC.Controllers
{
    public class Student_dataController : Controller
    {
        // GET: Student_data
        public ActionResult Index()
        {
            ViewBag.student = "Student Information";
            DataBaseHandler dataBaseHandler = new DataBaseHandler();//Database handler where we create connection
            ModelState.Clear();

            return View(dataBaseHandler.GetItemList());
        }
        [HttpGet]  // http get use to get values from user
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HomePage iList)
        {


            {
                if (ModelState.IsValid)
                {
                    DataBaseHandler ItemHandler = new DataBaseHandler();
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
        public ActionResult update(string email_id)
        {
            DataBaseHandler dataBaseHandler = new DataBaseHandler();
            return View(dataBaseHandler.GetItemList().Find(HomePage => HomePage.email_id == email_id));
        }
        [HttpPost]
        public ActionResult update(string email_id, HomePage updata)
        {

            try
            {

                DataBaseHandler ItemHandler1 = new DataBaseHandler();
                ItemHandler1.updatelist(updata);
                   
                        //ModelState.Clear();
                        return RedirectToAction("Index");
            }
            catch {

                return View();
            }
            }


        

        [HttpGet]

        public ActionResult deletedata(string email_id)
        {
            DataBaseHandler data = new DataBaseHandler();
            return View(data.GetItemList().Find(HomePage => HomePage.email_id == email_id));
        }
        [HttpPost]

        public ActionResult deletedata(string email_id, HomePage delete)
        {
            if (ModelState.IsValid)
            {
                DataBaseHandler data = new DataBaseHandler();
                if (data.deletelist(delete))

                {
                    ViewBag.Message = "item deleted Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login ls)

        {
            string constring = ConfigurationManager.ConnectionStrings["constrings"].ToString();
            SqlConnection con = new SqlConnection(constring);
            string qr = "select email_id , password from Registration_ass1 where email_id=@email_id and password = @password";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@email_id", ls.email_id);
            cmd.Parameters.AddWithValue("@password", ls.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["email_id"] = ls.email_id.ToString();
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
            string constring = ConfigurationManager.ConnectionStrings["constrings"].ToString();
            SqlConnection con = new SqlConnection(constring);
            string qr = "select first_name , middle_name,last_name from Registration_ass1 where email_id='"+Session["email_id"]+"'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds,"Registration_ass1");
            foreach (DataRow dr in ds.Tables["Registration_ass1"].Rows)
            {
                ViewData["fname"] = dr["first_name"].ToString();

                ViewData["mname"] = dr["middle_name"].ToString();

                ViewData["lname"] = dr["last_name"].ToString();
            }
            return View();
        }
        public ActionResult logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}