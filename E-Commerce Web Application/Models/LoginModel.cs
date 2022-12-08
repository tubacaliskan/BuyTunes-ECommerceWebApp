using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class LoginModel
    {
        [Required]
        [DisplayName("Your user Name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        public string CustumerPassword { get; set; }
        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }
    }
}