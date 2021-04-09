using Abp.Authorization.Users;
using Abp.ZeroCore.SampleApp.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly TenantManager tenantManager;
        private readonly RoleManager roleManager;
        public HomeController(TenantManager tenantManager, RoleManager roleManager)
        {
            this.tenantManager = tenantManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            //var user = new User() { TenantId = 1, Name = "admin", UserName = "admin", EmailAddress = "xsxsx", Surname = "admin", Password = "xxx" };
            //await userManager.CreateAsync(user);
            return Ok();
        }
    }
}
