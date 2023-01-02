using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class OrderDetailsModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderLineModel> OrderLines { get; set; }
        public string UserName { get; set; }
        public string AddressTitle { get; set; }
        public string CustumerCity { get; set; }
        public string CustumerZıpCode { get; set; }
        public string CustumerAdress { get; set; }
        public string CustumerAdress2 { get; set; }
        public string CustumerState { get; set; }

        public EnumOrderState OrderState { get; set; }
    }
    public class OrderLineModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }

        public string ProductDescription { get; set; }

    }
}