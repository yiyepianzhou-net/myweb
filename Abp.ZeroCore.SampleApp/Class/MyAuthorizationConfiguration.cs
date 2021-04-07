using Abp.Authorization;
using Abp.Collections;
using Abp.Configuration.Startup;

namespace Abp.ZeroCore.SampleApp.Class
{
   public class MyAuthorizationConfiguration: IAuthorizationConfiguration
    {
        public ITypeList<AuthorizationProvider> Providers { get; }

        public bool IsEnabled { get; set; }

        public MyAuthorizationConfiguration()
        {
            Providers = new TypeList<AuthorizationProvider>();
            IsEnabled = true;
        }
    }
}
