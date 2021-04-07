using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.Core;
using Abp.ZeroCore.SampleApp.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Repositorys
{
    public  class TenantRepository: EfCoreRepositoryBase<SampleAppDbContext, Tenant>,  IRepository<Tenant>
    {
        public TenantRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider):base(dbContextProvider)
        { 
        }
    }
}
