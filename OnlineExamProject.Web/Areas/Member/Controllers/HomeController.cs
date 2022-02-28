using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineExamProject.Entities.Concrete;
using OnlineExamProject.Web.Models;
using OnlineExamProject.Web.StringInfo;

namespace OnlineExamProject.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(UserManager<AppUser> userManager, IMapper mapper) 
        {
           
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
           var user=  await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.LoginUserId=user.Id;
            var random = new Random();
            var value = random.Next();
            ViewBag.ExamCode = value;
            ViewBag.result = BlogTitle.SendList("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[1]/section/div[3]/div/div/div/div/div/div[2]/a/h2");
            ViewBag.result2 = BlogTitle.SendListLink("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[1]/section/div[3]/div/div/div/div/div/div[2]/a");
            ViewBag.result5 = BlogTitle.SendListLink("https://www.wired.com/", "/ html / body / div[1] / div / main / div[1] / div[1] / section / div[3] / div / div / div / div / div / div[2] / a");
            ViewBag.result3 = BlogTitle.SendListLink("https://www.wired.com/", "//*[@id='main - content']/article/div[2]/div[1]/div[1]/div[1]/div/div/div[1]");

            ViewBag.result6 = BlogTitle.SendListLink("https://www.wired.com/", "/ html / body / div[1] / div / main / div[1] / div[1] / section / div[3] / div / div / div / div / div / div[2] / a[contains(@data-component,'recirc - river')]");

            // ViewBag.result4 = BlogTitle.Send("https://www.wired.com/gallery/best-kindle/", "/html/head/title");
            ViewBag.result4 = BlogTitle.SendList("https://www.wired.com/gallery/best-kindle/", "/ html / body / div[1] / div / main / article / div[2] / div[1] / div[1] / div[1] / div / div / div[1] / div / p");

            //ViewBag.result5 = BlogTitle.SendList("https://www.wired.com/", "//*[@id='main - content']/div[1]/div[6]/div/div/div[2]/div[2]/a/h3");

            return View();
        }
    }
}
