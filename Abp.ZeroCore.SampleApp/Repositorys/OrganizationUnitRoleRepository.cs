using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Organizations;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class OrganizationUnitRoleRepository : EfCoreRepositoryBase<SampleAppDbContext, OrganizationUnitRole, long>, IRepository<OrganizationUnitRole, long>
    {
        public OrganizationUnitRoleRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
