using Abp.Zero.EntityFrameworkCore;
using Abp.ZeroCore.SampleApp.Core;
using Microsoft.EntityFrameworkCore;

namespace Abp.ZeroCore.SampleApp.EntityFramework
{
    //TODO: Re-enable when IdentityServer ready
    public class SampleAppDbContext : AbpZeroDbContext<Tenant, Role, User, SampleAppDbContext>
    {
        public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Navigation(b => b.Roles).AutoInclude();
          
        }
    }
}
