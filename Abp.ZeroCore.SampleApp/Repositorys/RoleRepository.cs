using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.Core;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class RoleRepository: EfCoreRepositoryBase<SampleAppDbContext, Role>,IRepository<Role>
    {
        public RoleRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
