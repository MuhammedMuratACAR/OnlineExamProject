using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Interfaces
{
    public interface IExamService:IGenericService<Exam>
    {
        Exam FindByExamCode(int examCode);
        List<Exam> GetAllByUserId(int userId);
    }
}
