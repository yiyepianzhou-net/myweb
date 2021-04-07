using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Organizations;
using Abp.Runtime.Caching;
using Abp.Runtime.Caching.Configuration;
using Abp.Runtime.Caching.Memory;
using Abp.Zero.Configuration;
using Abp.ZeroCore.SampleApp.Class;
using Abp.ZeroCore.SampleApp.Core;
using Abp.ZeroCore.SampleApp.EntityFramework;
using Abp.ZeroCore.SampleApp.Repositorys;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repositorys;

namespace myweb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static readonly ILoggerFactory efLogger = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddControllersAsServices();


            services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<Abp.ZeroCore.SampleApp.Core.SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddFeatureValueStore<FeatureValueStore>()
                .AddDefaultTokenProviders();

            services.AddDbContextPool<SampleAppDbContext>(c =>
            {
                c.UseLoggerFactory(efLogger).UseMySql(Configuration["connection:str"], b => b.MigrationsAssembly("myweb"));
            }, poolSize: 64);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            #region 准备工作
            #region 多租户
            builder.RegisterType<SimpleDbContextProvider<SampleAppDbContext>>().As<IDbContextProvider<SampleAppDbContext>>();
            builder.RegisterType<TenantRepository>().As<IRepository<Tenant>>();
            builder.RegisterType<EditionRepository>().As<IRepository<Edition>>();
            builder.RegisterType<TenantFeatureSettingRespoistory>().As<IRepository<TenantFeatureSetting, long>>();
            builder.RegisterType<AbpZeroFeatureValueStore>().As<IAbpZeroFeatureValueStore>();
            builder.RegisterType<EditionManager>().AsSelf();
            builder.RegisterType<TenantManager>().AsSelf().PropertiesAutowired();
            #endregion

            #region 角色管理
            builder.RegisterType<RoleValidator<Role>>().As<IRoleValidator<Role>>();
            builder.RegisterType<UpperInvariantLookupNormalizer>().As<ILookupNormalizer>();
            builder.RegisterType<IdentityErrorDescriber>().AsSelf();
            builder.RegisterType<AsyncLocalCurrentUnitOfWorkProvider>().As<ICurrentUnitOfWorkProvider>();
            builder.RegisterType<MyUnitOfWorkManager>().As<IUnitOfWorkManager>();

            builder.RegisterType<RoleRepository>().As<IRepository<Role>>();
            builder.RegisterType<RolePermissionSettingResitorys>().As<IRepository<RolePermissionSetting, long>>();
            builder.RegisterType<RoleStore>().AsSelf();

            builder.RegisterType<IocManager>().As<IIocManager>();
            builder.RegisterType<MyAuthorizationConfiguration>().As<IAuthorizationConfiguration>();
            builder.RegisterType<PermissionManager>().As<IPermissionManager>();

            builder.RegisterType<CacheManager>().As<ICacheManager>();

            builder.RegisterType<MyRoleManagementConfig>().As<IRoleManagementConfig>();
            builder.RegisterType<OrganizationUnitRepository>().As<IRepository<OrganizationUnit, long>>();
            builder.RegisterType<OrganizationUnitRoleRepository>().As<IRepository<OrganizationUnitRole, long>>();
            builder.RegisterType<RoleManager>().AsSelf().PropertiesAutowired();
            #endregion
            #endregion
        }
    }
}
