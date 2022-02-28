using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Entities.Concrete
{
   public class Exam:ITable
    {
        public int ExamId { get; set; }
        public int ExamCode { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }
        public DateTime PostTime { get; set; } = DateTime.Now;

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<Question> Questions { get; set; }

    }
}
