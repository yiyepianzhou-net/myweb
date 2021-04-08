using Abp.ZeroCore.SampleApp.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace myweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly TenantManager tenantManager;
        private readonly RoleManager roleManager;
        private readonly UserManager userManager;
        public HomeController(TenantManager tenantManager, RoleManager roleManager, UserManager userManager)
        {
            this.tenantManager = tenantManager;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = new User() { TenantId = 1, Name = "admin", UserName = "admin" ,EmailAddress="xsxsx",Surname="admin",Password="xxx"};
           await userManager.CreateAsync(user);
            //var role = new Role() { Name = "role1",DisplayName="displayName" };
            //await roleManager.CreateAsync(role);
            //await tenantManager.DbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
