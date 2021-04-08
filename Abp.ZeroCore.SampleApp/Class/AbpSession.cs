using Abp.MultiTenancy;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class AbpSession : IAbpSession
    {
        public long? UserId => throw new NotImplementedException();

        public int? TenantId => 1;

        public MultiTenancySides MultiTenancySide =>MultiTenancySides.Tenant;

        public long? ImpersonatorUserId => throw new NotImplementedException();

        public int? ImpersonatorTenantId => throw new NotImplementedException();

        public IDisposable Use(int? tenantId, long? userId)
        {
            throw new NotImplementedException();
        }
    }
}
