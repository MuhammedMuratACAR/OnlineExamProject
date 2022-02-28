using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Concrete
{
    public class QuestionManager:GenericManager<Question>,IQuestionService
    {
        private readonly IGenericDal<Question> _genericDal;
        public QuestionManager(IGenericDal<Question> genericDal):base(genericDal)
        {

        }
    }
}
