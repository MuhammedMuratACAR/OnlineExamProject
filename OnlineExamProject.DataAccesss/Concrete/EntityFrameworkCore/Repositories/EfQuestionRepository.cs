using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Repositories
{
    public class EfQuestionRepository : EfGenericRepository<Question>, IQuestionDal
    {
    }
}
