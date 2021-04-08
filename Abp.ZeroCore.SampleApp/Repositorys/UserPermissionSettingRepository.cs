using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
   public class UserPermissionSettingRepository: EfCoreRepositoryBase<SampleAppDbContext,UserPermissionSetting,long>, IRepository<UserPermissionSetting, long>
    {
        public UserPermissionSettingRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
