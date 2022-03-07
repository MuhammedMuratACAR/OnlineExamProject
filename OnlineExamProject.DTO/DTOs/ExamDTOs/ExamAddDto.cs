using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DTO.DTOs.ExamDTOs
{
    public class ExamAddDto
    {
        public int ExamCode { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }
        public int AppUserId { get; set; }
    }
}
