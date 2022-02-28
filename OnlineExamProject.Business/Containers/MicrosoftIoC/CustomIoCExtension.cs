using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnlineExamProject.Business.Concrete;
using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.Business.ValidationRules.FluentValidation;
using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Repositories;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.DTO.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IExamService, ExamManager>();
            services.AddScoped<IExamDal, EfExamRepository>();

            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IQuestionDal, EfQuestionRepository>();


            services.AddTransient<IValidator<AppUserSignInDto>, AppUserSignInValidator>();
            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddValidator>();
        }
    }
}
