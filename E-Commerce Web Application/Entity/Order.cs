using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
        public string UserName { get; set; }
        public string AddressTitle { get; set; }
        public string CustumerCity { get; set; }
        public string CustumerZıpCode { get; set; }
        public string CustumerAdress { get; set; }
        public string CustumerAdress2 { get; set; }
        public string CustumerState { get; set; }

        public EnumOrderState OrderState{ get; set; }
    }

    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public virtual Product Product { get; set; }
    }
}