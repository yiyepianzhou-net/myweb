using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.MultiTenancy;
using Abp.ZeroCore.SampleApp.EntityFramework;


namespace Repositorys
{
    public class TenantFeatureSettingRepository: EfCoreRepositoryBase<SampleAppDbContext, TenantFeatureSetting,long>, IRepository<TenantFeatureSetting,long>
    {
        public TenantFeatureSettingRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
