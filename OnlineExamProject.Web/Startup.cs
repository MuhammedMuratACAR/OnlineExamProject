using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineExamProject.Business.Containers.MicrosoftIoC;
using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Context;
using OnlineExamProject.Entities.Concrete;
using OnlineExamProject.Web.CustomCollectionExtensions;

namespace OnlineExamProject.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencies();

            //services.AddEntityFrameworkSqlite().AddDbContext<OnlineExamContextt>(
            //        options => { options.UseSqlite("Data Source=OnlineExam.db"); });
            //services.AddEntityFrameworkSqlite().AddDbContext<OnlineExamContextt>();

            // services.AddDbContext(options => { options.UseSQLite(Configuration.GetConnectionString("DefaultConnection")); });
            //services.AddDbContext<OnlineExamContextt>(options => { options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")); });       

            //services.AddDbContext<OnlineExamContextt>(options =>
            //    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
         
            services.AddDbContext<OnlineExamContextDb>();
            services.AddCustomIdentity();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews().AddFluentValidation();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
          
            }


            app.UseStatusCodePagesWithRedirects("/Home/StatusCode?code={0}");
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            IdentityInitializer.SeedData(userManager, roleManager).Wait();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
