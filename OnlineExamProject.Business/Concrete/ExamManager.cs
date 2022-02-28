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
     
        public ExamManager(IGenericDal<Exam> genericDal):base(genericDal)
        {

        }
    }
}
