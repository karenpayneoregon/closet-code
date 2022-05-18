using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikSampleApp.Models;

namespace TelerikSampleApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Add framework services.
            services
                .AddControllersWithViews()
                // Maintain property names during serialization. See:
                // https://github.com/aspnet/Announcements/issues/194
                .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            // Add Kendo UI services to the services container
            services.AddKendo();

            /*
             * https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
             */
            services.AddDbContext<NorthWind2020Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("NorthWind2020Context")));

            /*
             * https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-compilation?view=aspnetcore-3.0&tabs=visual-studio
             */

#if DEBUG
            /*
             * Requires package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
             * https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-compilation?view=aspnetcore-5.0&tabs=visual-studio
             */
            //services.AddRazorPages().AddRazorRuntimeCompilation();
            //services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddControllersWithViews().AddRazorRuntimeCompilation();

#endif


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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