using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class RegisterCustomer
    {
        public int CustumerId { get; set; }
        public string CustumerName { get; set; }
        public string CustumerSurname { get; set; }
        public string CustumerEmail { get; set; }
        public string CustumerPhone { get; set; }
        public string CustumerPassword { get; set; }
        public string CustumerCity { get; set; }
        public string CustumerZıpCode { get; set; }
        public string CustumerAdress { get; set; }
        public string CustumerAdress2 { get; set; }
        public string CustumerState { get; set; }
        public bool CustumerIscheck { get; set; }
    }
}