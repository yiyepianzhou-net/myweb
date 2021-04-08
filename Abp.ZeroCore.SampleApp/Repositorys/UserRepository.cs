using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.Core;
using Abp.ZeroCore.SampleApp.EntityFramework;


namespace Abp.ZeroCore.SampleApp.Repositorys
{
   public class UserRepository: EfCoreRepositoryBase<SampleAppDbContext, User,long>,IRepository<User, long>
    {
        public UserRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
