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
using OnlineExamProject.DTO.DTOs.QuestionDTOs;
using OnlineExamProject.Entities.Concrete;
using OnlineExamProject.Web.StringInfo;

namespace OnlineExamProject.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class QuestionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IQuestionService _questionService;
        private readonly IExamService _examService;
        public QuestionController(UserManager<AppUser> userManager, IMapper mapper, IQuestionService questionService, IExamService examService)
        {

            _mapper = mapper;
            _userManager = userManager;
            _questionService = questionService;
            _examService = examService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveQuestion(QuestionAddDto model)
        {
            if (ModelState.IsValid)
            {
                _questionService.Save(new Question
                {
                    ExamId = model.ExamId,
                    QuestionText=model.QuestionText,
                    FirstOption=model.FirstOption,
                    SecondOption=model.SecondOption,
                    ThirtOption=model.ThirtOption,
                    FourthOption=model.FourthOption,
                    CurrentAnswer=model.CurrentAnswer

                });
                var jsonQuestion = JsonConvert.SerializeObject(model);
                return Json(jsonQuestion);
            }
            return View();

        }

        public IActionResult ExamStart(int id)
        {
            var exam = _examService.GetById(id);
            ViewBag.ExamTitle = exam.ExamTitle;
            ViewBag.ExamDescription = exam.ExamDescription;
            return View(_mapper.Map<List<QuestionListDto>>(_questionService.GetAllQuestionByExamId(id)));
         
        }

    }
}
