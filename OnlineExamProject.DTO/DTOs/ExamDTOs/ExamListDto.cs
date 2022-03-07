using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DTO.DTOs.ExamDTOs
{
    public class ExamListDto
    {
        public int ExamId { get; set; }
        public int ExamCode { get; set; }
        public string ExamTitle { get; set; }
        public DateTime PostTime { get; set; }

    }
}
