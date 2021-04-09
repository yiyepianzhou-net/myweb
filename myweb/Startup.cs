using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Uow;
using Abp.Localization;
using Abp.MultiTenancy;
using Abp.Organizations;
using Abp.Reflection.Extensions;
using Abp.Runtime;
using Abp.Runtime.Caching;
using Abp.Runtime.Remoting;
using Abp.Runtime.Session;
using Abp.Zero;
using Abp.Zero.Configuration;
using Abp.ZeroCore.SampleApp;
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
using System.Linq;
using System.Reflection;

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
            #region ׼������
            var sample = Assembly.Load("Abp.ZeroCore.SampleApp");
            var zero = Assembly.Load("Abp");
            var asp = Assembly.Load("Microsoft.Extensions.Identity.Core");
            var common = Assembly.Load("Abp.Zero.Common");
            #region Manager
            //builder.RegisterType<DataContextAmbientScopeProvider<SessionOverride>>().As<IAmbientScopeProvider<SessionOverride>>();
            builder.RegisterType<SimpleDbContextProvider<SampleAppDbContext>>().As<IDbContextProvider<SampleAppDbContext>>();

            builder.RegisterAssemblyTypes(zero).Where(t => t.GetConstructors().Any(c => c.IsPublic) /*&& !t.Name.EndsWith("IocResolver")*/)
             .AsImplementedInterfaces().AsSelf();

            builder.RegisterAssemblyTypes(sample, zero).Where(t => t.GetConstructors().Any(c => c.IsPublic)).AsSelf().AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(asp).Where(t => t.GetConstructors().Any(c => c.IsPublic)).AsSelf().AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(common).Where(t => t.GetConstructors().Any(c => c.IsPublic)).AsSelf().AsImplementedInterfaces();

            builder.RegisterType<IocManager>().As<IIocManager>().As<IIocResolver>();
            #endregion
            #endregion
        }
    }
}
