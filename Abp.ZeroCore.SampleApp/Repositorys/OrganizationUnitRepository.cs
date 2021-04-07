using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Organizations;
using Abp.ZeroCore.SampleApp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Repositorys
{
    public class OrganizationUnitRepository : EfCoreRepositoryBase<SampleAppDbContext, OrganizationUnit,long>, IRepository<OrganizationUnit, long>
    {
        public OrganizationUnitRepository(IDbContextProvider<SampleAppDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
