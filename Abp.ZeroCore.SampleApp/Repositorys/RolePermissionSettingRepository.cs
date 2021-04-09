using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
   public class RolePermissionSettingRepository: EfCoreRepositoryBase<SampleAppDbContext, RolePermissionSetting, long>, IRepository<RolePermissionSetting, long>
    {
        public RolePermissionSettingRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
