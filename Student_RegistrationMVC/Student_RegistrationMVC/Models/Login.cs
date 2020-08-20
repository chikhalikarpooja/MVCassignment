using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Student_RegistrationMVC.Models
{
    public class Login

    {
        [Required(ErrorMessage ="Please Enter Correct Email_id")]
       [Display(Name ="please enter email_id")]
    public string email_id { get; set; }
        [Required(ErrorMessage = "Please Enter Correct Password")]
        [Display(Name = "please enter password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}