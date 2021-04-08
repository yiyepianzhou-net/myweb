using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class UserClaimRepository: EfCoreRepositoryBase<SampleAppDbContext, UserClaim,long>, IRepository<UserClaim, long>
    {
        public UserClaimRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
