using E_Commerce_Web_Application.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace E_Commerce_Web_Application.Identity
{
    public class IdentityDataContex : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContex() : base("dataConnection")
        {
            
        }
        
    }
}