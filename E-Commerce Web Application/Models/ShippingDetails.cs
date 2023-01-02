using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class ShippingDetails
    {
        
        [DisplayName("Name and Surname")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a addres title")]
        [DisplayName("AddressTitle")]
        public string AddressTitle { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        [DisplayName("Your City")]
        public string CustumerCity { get; set; }

        [DisplayName("Your Zıp Code")]
        public string CustumerZıpCode { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        [DisplayName("Your Address")]
        public string CustumerAdress { get; set; }
        [DisplayName("Your Address Details")]
        public string CustumerAdress2 { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        [DisplayName("City's State")]
        public string CustumerState { get; set; }
      
    }
}