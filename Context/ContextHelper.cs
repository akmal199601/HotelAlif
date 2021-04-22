using System.Linq;
using System.Threading.Tasks;
using HotelAlif.Models.Account;
using Microsoft.AspNetCore.Identity;

namespace HotelAlif.Context
{
    public class ContextHelper
    {
        public static async Task Seeding(HotelAlifContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var adminRole = new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                };
                var userRole = new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                };
                await roleManager.CreateAsync(adminRole);
                await roleManager.CreateAsync(userRole);
            }

            if (!userManager.Users.Where(p => p.UserName.Equals("Admin")).Any())
            {
                var adminUser = new User
                {
                    UserName = "Admin",
                    Email = "Admin@gmail.com"
                };
                var result = await userManager.CreateAsync(adminUser, "password");

                if (result.Succeeded)
                {
                    var role = await roleManager.FindByNameAsync("Admin");
                    await userManager.AddToRoleAsync(await userManager.FindByNameAsync("Admin"), role.Name);
                }
            }
        }
    }
}