using Microsoft.Extensions.DependencyInjection;
using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Context;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamProject.Web.CustomCollectionExtensions
{
    public static class CustomExtensions
    {
        public static void AddCustomIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(opt => {
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            })
               .AddEntityFrameworkStores<OnlineExamContextDb>();

            services.ConfigureApplicationCookie(opt => {
                opt.Cookie.Name = "OnlineExam";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;//başka wep sayfasında paylaşılmasın
                opt.Cookie.HttpOnly = true; //document diyerek cookie bilgisine ulaşılmasını engelliyor
                opt.ExpireTimeSpan = TimeSpan.FromDays(20); // cookie ne kadar süre ayakta kalması durumu
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest; //istek ne ise o şekilde davranır http ise http, https ise https olarak davranır
                opt.LoginPath = "/Home/Index";
            });
        }

       
    }
}
