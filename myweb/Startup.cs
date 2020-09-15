
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using myweb.Models;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Unit;

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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContextPool<MywebDbcontext>(c =>
            {
                c.UseLoggerFactory(efLogger).UseSqlServer(Configuration["connection:str"]);
            }, poolSize: 64);

            //services.AddDbContext<MywebDbcontext>(c => c.UseSqlServer(Configuration["connection:str"]).UseLoggerFactory(efLogger).AddInterceptors(new HintCommandInterceptor()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
    }
}
