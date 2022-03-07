using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DTO.DTOs.QuestionDTOs
{
    public class QuestionListDto
    {
        public string QuestionText { get; set; }
        public string FirstOption { get; set; }
        public string SecondOption { get; set; }
        public string ThirtOption { get; set; }
        public string FourthOption { get; set; }
        public string CurrentAnswer { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
