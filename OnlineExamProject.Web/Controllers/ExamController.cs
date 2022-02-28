using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamProject.Web.Models;

namespace OnlineExamProject.Web.Controllers
{
    
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var random = new Random();
            var value = random.Next();
            ViewBag.ExamCode= value;
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
