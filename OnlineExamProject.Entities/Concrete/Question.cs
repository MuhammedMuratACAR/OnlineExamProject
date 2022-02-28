using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Entities.Concrete
{
    public class Question:ITable
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string FirstOption { get; set; }
        public string SecondOption { get; set; }
        public string ThirtOption { get; set; }
        public string FourthOption { get; set; }
        public string CurrentAnswer { get; set; }

        public int ExamCode { get; set; }
        public Exam Exam { get; set; }

    }
}
