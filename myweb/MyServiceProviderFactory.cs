using Microsoft.Extensions.DependencyInjection;
using System;

namespace myweb
{
    /// <summary>
    /// 服务提供器
    /// </summary>
    public class MyServiceProviderFactory : IServiceProviderFactory<IServiceProvider>
    {
        public IServiceProvider CreateBuilder(IServiceCollection services)
        {
            return services.BuildServiceProvider();
        }

        public IServiceProvider CreateServiceProvider(IServiceProvider containerBuilder)
        {
            return containerBuilder;
        }
    }
}
