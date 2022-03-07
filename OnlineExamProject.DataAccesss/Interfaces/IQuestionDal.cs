using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.DataAccesss.Interfaces
{
    public interface IQuestionDal : IGenericDal<Question>
    {
        List<Question> GetAllQuestionByExamId(int examId);
    }
}
