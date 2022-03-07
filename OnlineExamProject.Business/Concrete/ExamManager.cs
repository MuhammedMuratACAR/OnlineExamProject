using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamProject.Business.Concrete
{
    public class ExamManager:GenericManager<Exam>,IExamService
    {
        private readonly IGenericDal<Exam> _genericDal;
        private readonly IExamDal _examDal;
   
     
        public ExamManager(IGenericDal<Exam> genericDal, IExamDal examDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _examDal = examDal;
        }

        public Exam FindByExamCode(int examCode)
        {
            return _genericDal.Get(I => I.ExamCode == examCode);
        }

        public List<Exam> GetAllByUserId(int userId)
        {
            return _examDal.GetAllByUserId(userId);
        }
    }
}
