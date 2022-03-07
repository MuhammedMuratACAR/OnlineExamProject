using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.DTO.DTOs.ExamDTOs;
using OnlineExamProject.DTO.DTOs.QuestionDTOs;
using OnlineExamProject.Entities.Concrete;
using OnlineExamProject.Web.Areas.Member.Models;
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
        private readonly IExamService _examService;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> userManager, IMapper mapper, IExamService examService, SignInManager<AppUser> signInManager)
        {

            _mapper = mapper;
            _userManager = userManager;
            _examService = examService;
            _signInManager = signInManager;
  
        }
        public async Task<IActionResult> Index()
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(_mapper.Map<List<ExamListDto>>(_examService.GetAllByUserId(user.Id)));

        }

        [HttpGet]
        public async Task<IActionResult> SaveExam()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.LoginUserId = user.Id;
            var random = new Random();
            var value = random.Next();
            ViewBag.ExamCode = value;
            ViewBag.result = BlogTitle.SendList("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[1]/section/div[3]/div/div/div/div/div/div[2]/a/h2");

            ViewBag.result2 = BlogTitle.SendListLink("https://www.wired.com/", "/ html / body / div[1] / div / main / div[1] / div[1] / section / div[3] / div / div / div / div / div / div[2] / a");

            return View();
        }

        [HttpPost]
        public IActionResult SaveExam(ExamAddDto model)
        {
            if (ModelState.IsValid)
            {
                _examService.Save(new Exam
                {
                    AppUserId = model.AppUserId,
                    ExamCode = model.ExamCode,
                    ExamTitle = model.ExamTitle,
                    ExamDescription = model.ExamDescription
                });
                var jsonExam = JsonConvert.SerializeObject(model);
                return Json(jsonExam);
            }
            return View();

        }

        public IActionResult GetExamId(int examCode)
        {
            var exam = _examService.FindByExamCode(examCode);
            var examId = exam.ExamId;
            var jsonExamId = JsonConvert.SerializeObject(examId);
            return Json(jsonExamId);
        }

        public async Task<IActionResult> GetUserExamList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(_mapper.Map<List<ExamListDto>>(_examService.GetAllByUserId(user.Id)));

        }

        public IActionResult DeleteExam(int id)
        {

            var examToBeDeleted = _examService.GetById(id);

            if (examToBeDeleted != null)

            {

                _examService.Delete(examToBeDeleted);

            }
            return Json(null);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

    }
}
