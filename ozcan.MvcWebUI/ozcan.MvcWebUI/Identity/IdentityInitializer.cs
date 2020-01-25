using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ozcan.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ozcan.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            // Rolleri
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "ozcanbiyik"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "ozcan", Surname = "biyik", UserName = "ozcanbiyik", Email = "zcnbyk@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "yudumbiyik"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "yudum", Surname = "biyik", UserName = "yudumbiyik", Email = "yudumbiyik@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }
    }
}