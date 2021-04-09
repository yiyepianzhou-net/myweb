using Abp.AutoMapper;
using Abp.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Abp.ZeroCore.SampleApp.Application;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.ZeroCore.SampleApp
{
    [DependsOn(typeof(AbpZeroCoreEntityFrameworkCoreModule), typeof(AbpAutoMapperModule))]
    public class AbpZeroCoreSampleAppModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public override void PreInitialize()
        {
            //Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Configuration.Features.Providers.Add<AppFeatureProvider>();
            //Configuration.CustomConfigProviders.Add(new TestCustomConfigProvider());
            //Configuration.CustomConfigProviders.Add(new TestCustomConfigProvider2());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroCoreSampleAppModule).GetAssembly());

            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                CustomDtoMapper.CreateMappings(configuration, new MultiLingualMapContext(
                    IocManager.Resolve<ISettingManager>()
                ));
            });
        }
    }

    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration, MultiLingualMapContext context)
        {
    
        }
    }
}
