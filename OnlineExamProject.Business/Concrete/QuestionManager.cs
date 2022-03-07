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
        private readonly IQuestionDal _questionDal;
        public QuestionManager(IGenericDal<Question> genericDal, IQuestionDal questionDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _questionDal = questionDal;
        }

        public List<Question> GetAllQuestionByExamId(int examId)
        {
            return _questionDal.GetAllQuestionByExamId(examId);
        }
    }
}
