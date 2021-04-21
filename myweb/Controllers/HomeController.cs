using Abp.Authorization;
using Abp.ZeroCore.SampleApp.Application;
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
        public HomeController(TenantManager tenantManager, RoleManager roleManager)
        {
            this.tenantManager = tenantManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            //await userManager.CreateAsync(Abp.ZeroCore.SampleApp.Core.User.CreateTenantAdminUser(1,"XXX"));
            /*oleManager.SetGrantedPermissionsAsync();*/
            //var user = Abp.ZeroCore.SampleApp.Core.User.CreateTenantAdminUser(1, "xxx");
            //user.Name = "admin1";
            //await userManager.CreateAsync(user);
            //await userManager.AddToRoleAsync(user,"role1");
            return Ok();
        }
    }
}
