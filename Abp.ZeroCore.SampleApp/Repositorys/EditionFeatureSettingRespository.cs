using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
   public  class EditionFeatureSettingRespository: EfCoreRepositoryBase<SampleAppDbContext, EditionFeatureSetting,long>,IRepository<EditionFeatureSetting,long>
    {
        public EditionFeatureSettingRespository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
