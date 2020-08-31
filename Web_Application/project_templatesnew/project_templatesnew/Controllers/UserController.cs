using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using project_templatesnew.Models;
namespace project_templatesnew.Controllers
{
    public class UserController : Controller
    {
        User_Model_context obj = new User_Model_context(); // user_Model is a context 
        // GET: New_User_Reg
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(New_User_Reg model)
        {
            New_User_Reg um = new New_User_Reg();
            um.First_Name = model.First_Name;
            um.Last_Name = model.Last_Name;
            um.Gender = model.Gender;
            um.Phone_Number = model.Phone_Number;
            um.Address = model.Address;
            um.Email = model.Email;
            um.Password = model.Password;
            um.Confirm_Password = model.Confirm_Password;
            obj.New_User_Reg.Add(um);
            obj.SaveChanges();
            return RedirectToAction("Login");


        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(New_User_Reg model)
        {
            bool isvalid = obj.New_User_Reg.Any(x => x.Email == model.Email && x.Password == model.Password);
            if (isvalid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);
                return RedirectToAction("UserDashboard");

            }
            else
            {
                ModelState.AddModelError("", "Invalid emailid and password");
            }
            return View();

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }


        public ActionResult UserDashboard()
        {


            return View();
        }


    }
}
       