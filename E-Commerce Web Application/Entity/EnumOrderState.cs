using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace E_Commerce_Web_Application.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Awaiting Approval")]
        Waiting,
        [Display(Name = "Your Order Has Been Received")]
        Received,
        [Display(Name = "Getting Ready")]
        Ready,
        [Display(Name = "In Cargo")]
        Cargo,
        [Display(Name = "Order Completed")]
        Completed,
        [Display(Name = "Order Canceled")]
        Cancel
    }
}