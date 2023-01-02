using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class RegisterCustumer
    {
        //public int CustumerId { get; set; }
        [Required]
        [DisplayName("Your Name")]
        public string CustumerName { get; set; }
        [Required]
        [DisplayName("Your surname")]
        public string CustumerSurname { get; set; }
        [Required]
        [DisplayName("Your user Name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Your E mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid E-mail Address")]
        public string CustumerEmail { get; set; }
        [Required]
        [DisplayName("Your Phone Number")]
        [Phone(ErrorMessage = "Enter Valid Phone Number")]
        public string CustumerPhone { get; set; }
        [Required]
        [DisplayName("Password")]
        public string CustumerPassword { get; set; }
        [Required]
        [DisplayName("Enter Password Again")]
        [Compare("CustumerPassword", ErrorMessage = "Passwords do not Match. Please Be Careful!")]
        public string CustumerRePassword { get; set; }
        [DisplayName("Your Gender")]
        public string CustumerGender { get; set; }
        [Required]
        [DisplayName("Your City")]
        public string CustumerCity { get; set; }
  
        [DisplayName("Your Zıp Code")]
        public string CustumerZıpCode { get; set; }

        [DisplayName("Your Address")]
        public string CustumerAdress { get; set; }
        [DisplayName("Your Address Details")]
        public string CustumerAdress2 { get; set; }
        [DisplayName("City's State")]
        public string CustumerState { get; set; }
        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }
    }
}