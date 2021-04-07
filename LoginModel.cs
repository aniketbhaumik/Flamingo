using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirlineProject.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="First name is required")]
        [Display(Name = "First Name")]
        [MinLength(1)]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "last Name")]
        [MinLength(1)]
        public string LName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage ="password should be of minimum length 4")]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        public string PhoneNo { get; set; }

        public string Addr { get; set; }

        public int PID { get; set; }

        [Required(ErrorMessage ="Age is required")]
        public int Age { get; set; }
    }
}