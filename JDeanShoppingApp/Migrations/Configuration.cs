using JDeanShoppingApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;
using System.Linq;

namespace JDeanShoppingApp.Migrations
//seed method
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext> 
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            if(!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin"});

            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "jessc.dean@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "jessc.dean@gmail.com",
                    Email = "jessc.dean@gmail.com",
                    FirstName = "Jessica",
                    LastName = "Dean",                   
                },"Applesauce3?");
            }
            var userId = userManager.FindByEmail("jessc.dean@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");
        }
    }
}