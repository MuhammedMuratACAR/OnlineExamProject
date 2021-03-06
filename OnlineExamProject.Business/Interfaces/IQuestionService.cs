using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Interfaces
{
    public interface IQuestionService:IGenericService<Question>
    {
        List<Question> GetAllQuestionByExamId(int examId);
    }
}
