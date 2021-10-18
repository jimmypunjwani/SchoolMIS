using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SchoolMIS.Models;
using System;

[assembly: OwinStartupAttribute(typeof(SchoolMIS.Startup))]
namespace SchoolMIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Add funtion to run with:
            CreateRolesAndUsers();
        }

        //Creating custom function:
        public void CreateRolesAndUsers()
        {
            //Defining Application Db Context:
            var context = new ApplicationDbContext();

            //Intitalizing Objects for RoleManager and UserManager
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Defining Admin Role if not exist:
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            //Defining Supervisor Role if not exist:
            if (!roleManager.RoleExists("Supervisor"))
            {
                var role = new IdentityRole();
                role.Name = "Supervisor";
                roleManager.Create(role);
            }

            //Defining Teacher Role if not exist:
            if (!roleManager.RoleExists("Teacher"))
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                roleManager.Create(role);
            }

            //Defining Student Role if not exist:
            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);
            }

            //Adding admin user and assign Role Admin:
            var user = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@schoolmis.com",
                BirthDate = DateTime.Now
            };

            var password = "password";

            //Creating admin user if not exist:
            var adminUsr = userManager.FindByName("admin");

            if (adminUsr == null)
            {
                //Create admin user:
                var usr = userManager.Create(user, password);
                //If user is created successfully then assign Admin role to it:
                if (usr.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Admin");
                }
            }
            



        }
    }
}
