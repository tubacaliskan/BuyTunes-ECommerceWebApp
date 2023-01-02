using E_Commerce_Web_Application.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Identity
{
    public class IdentityDataInitializer : CreateDatabaseIfNotExists<IdentityDataContex>
    {
        protected override void Seed(IdentityDataContex context)
        {

            // rolleri oluştur
            if (!context.Roles.Any(i=>i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Desciption = "seller role" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Desciption = "customer role" };
                manager.Create(role);
            }

            // userları oluştur

            if (!context.Users.Any(i => i.Name == "tubacaliskan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() {Name = "Zeynep Tuba", Surname = "Çalışkan", UserName = "tubacaliskan", Email = "zeynep.tuba.caliskan@outlook.com"};
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "mfgulmez"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Mehmet Fatih", Surname = "Gülmez", UserName = "mfgulmez", Email = "mehmet.fatih.gulmez@outlook.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}