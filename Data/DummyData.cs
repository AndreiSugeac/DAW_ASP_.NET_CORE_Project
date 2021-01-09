using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketLine.Models;

namespace TicketLine.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context, 
                                            UserManager<ApplicationUser> userManager,
                                            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the member role";

            string password = "Password1!";

            if( await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if(await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if(await userManager.FindByNameAsync("administrator@email.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "administrator@email.com",
                    Email = "administrator@email.com",
                    FirstName = "Andrei",
                    LastName = "Sugeac",
                    Gender = "Male",
                    PhoneNumber = "+40735663293"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("user@email.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "user@email.com",
                    Email = "user@email.com",
                    FirstName = "User",
                    LastName = "Test",
                    Gender = "Female",
                    PhoneNumber = "+40123456789"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
