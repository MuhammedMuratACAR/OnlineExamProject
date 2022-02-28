using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineExamProject.Entities.Concrete;

namespace OnlineExamProject.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UserManager<AppUser> _userManager;
        public BaseController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        protected async Task<AppUser> GetirGirisYapanKullanici()
        {
            return await _userManager.FindByNameAsync(User.Identity.Name);
        }
    }
}
