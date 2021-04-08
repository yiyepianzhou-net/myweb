using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class UserOrganizationUnitRepository: EfCoreRepositoryBase<SampleAppDbContext, UserOrganizationUnit,long>, IRepository<UserOrganizationUnit, long>
    {
        public UserOrganizationUnitRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
