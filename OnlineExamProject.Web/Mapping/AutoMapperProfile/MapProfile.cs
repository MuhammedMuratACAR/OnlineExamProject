using AutoMapper;
using OnlineExamProject.DTO.DTOs.AppUserDTOs;
using OnlineExamProject.DTO.DTOs.ExamDTOs;
using OnlineExamProject.DTO.DTOs.QuestionDTOs;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamProject.Web.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();

            CreateMap<AppUserSignInDto, AppUser>();
            CreateMap<AppUser, AppUserSignInDto>();

            CreateMap<ExamListDto, Exam>();
            CreateMap<Exam, ExamListDto>();

            CreateMap<ExamAddDto, Exam>();
            CreateMap<Exam, ExamAddDto>();

            CreateMap<QuestionListDto, Question>();
            CreateMap<Question, QuestionListDto>();

            CreateMap<QuestionAddDto, Question>();
            CreateMap<Question, QuestionAddDto>();
        }
    }
}
