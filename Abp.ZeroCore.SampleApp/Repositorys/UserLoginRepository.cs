using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;
namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class UserLoginRepository : EfCoreRepositoryBase<SampleAppDbContext, UserLogin,long>, IRepository<UserLogin, long>
    {
        public UserLoginRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
