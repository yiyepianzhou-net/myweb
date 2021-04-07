using Abp.Application.Editions;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.ZeroCore.SampleApp.EntityFramework;

namespace Repositorys
{
   public  class EditionRepository: EfCoreRepositoryBase<SampleAppDbContext, Edition>, IRepository<Edition>
    {
        public EditionRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
