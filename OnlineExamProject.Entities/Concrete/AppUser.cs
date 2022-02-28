using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;
using OnlineExamProject.Entities.Interfaces;

namespace OnlineExamProject.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Exam> Exams { get; set; }
    }
   
}
