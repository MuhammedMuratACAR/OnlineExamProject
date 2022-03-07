using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Interfaces
{
    public interface IExamDal : IGenericDal<Exam>
    {
        List<Exam> GetAllByUserId(int userId);
       
    }
}
