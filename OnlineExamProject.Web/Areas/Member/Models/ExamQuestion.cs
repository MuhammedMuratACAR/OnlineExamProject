using OnlineExamProject.DTO.DTOs.ExamDTOs;
using OnlineExamProject.DTO.DTOs.QuestionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamProject.Web.Areas.Member.Models
{
    public class ExamQuestion
    {
        public ExamAddDto examAddDtos { get; set; }
        public QuestionAddDto questionAddDtos { get; set; }

    }
}
