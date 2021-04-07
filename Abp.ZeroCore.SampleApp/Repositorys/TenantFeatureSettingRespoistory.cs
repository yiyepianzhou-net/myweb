using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.MultiTenancy;
using Abp.ZeroCore.SampleApp.EntityFramework;


namespace Repositorys
{
    public class TenantFeatureSettingRespoistory: EfCoreRepositoryBase<SampleAppDbContext, TenantFeatureSetting,long>, IRepository<TenantFeatureSetting,long>
    {
        public TenantFeatureSettingRespoistory(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
