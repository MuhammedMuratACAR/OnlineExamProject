using Microsoft.EntityFrameworkCore;
using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Context;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Repositories
{
    public class EfExamRepository : EfGenericRepository<Exam>, IExamDal
    {
       
        public List<Exam> GetAllByUserId(int userId)
        {   
            using var context = new OnlineExamContextDb();
            return context.Exams.Where(I => I.AppUserId == userId).OrderByDescending(I=>I.PostTime).ToList();
        }

        
       

    }
}
