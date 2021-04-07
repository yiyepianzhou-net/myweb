using Abp.ZeroCore.SampleApp.Core;
using Microsoft.AspNetCore.Mvc;
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
            var role = new Role() { Name = "role1" };
            await roleManager.CreateAsync(role);
            //var tenant = new Tenant("tenancyName2", "admin2");
            //await tenantManager.CreateAsync(tenant);
            await tenantManager.DbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
