using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Identity
{
    public class ApplicationRole :IdentityRole
    {
        public string Desciption { get; set; }
        public ApplicationRole()
        {

        }
        // aşırı yüklenmiş fonk. role name yıkarıdaki fonk ile getirilebiliniyor ama description ı getirmek için bunu kullanıyoruz
        public ApplicationRole(string roleName,string description)
        {
            this.Desciption = description;
        }        
    }
}