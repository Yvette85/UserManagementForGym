namespace UserManagementForGym.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserManagementForGym.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UserManagementForGym.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserManagementForGym.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //




            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            var emails = new[] { "reine@lexicon.se", "carine@lexicon.se", "vava@lexicon.se", "john@lexicon.se" };

            foreach (var email in emails)
            {
                if (context.Users.Any(u => u.UserName == email)) continue;

                var user = new ApplicationUser { UserName = email, Email = email };
                var result = userManager.Create(user, "Football1!");
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join("\n", result.Errors));
                }


            }

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var roleNames = new[] { "Admin", "Member" };

                foreach (var roleName in roleNames)
                {
                    if (context.Roles.Any(r => r.Name == roleName)) continue;

                    var role = new IdentityRole { Name = roleName };
                   var result = roleManager.Create(role);

                    if (!result.Succeeded)
                    {
                        throw new Exception(string.Join("\n", result.Errors));
                    }


                }



        }
        }
    }

