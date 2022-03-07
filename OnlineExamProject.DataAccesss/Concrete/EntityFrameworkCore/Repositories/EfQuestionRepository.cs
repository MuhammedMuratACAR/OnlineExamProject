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
    public class EfQuestionRepository : EfGenericRepository<Question>, IQuestionDal
    {
        public List<Question> GetAllQuestionByExamId(int examId)
        {
            using var context = new OnlineExamContextDb();

            return context.Questions.Include(I => I.Exam).Where(I => I.ExamId == examId).ToList();

            //return context.Questions
            //      .Join(context.Exams,
            //            q => q.ExamId,
            //            e => e.ExamId,
            //            (question, exam) => new
            //            {
            //                exam,
            //                question
            //            }
            //            ).Where(I => I.question.ExamId == examId).Select(eq => new
            //            {

            //                ExamTitle = eq.exam.ExamTitle,
            //                ExamDescription = eq.exam.ExamDescription,
            //                QuestionText = eq.question.QuestionText,
            //                FirstOption = eq.question.FirstOption,
            //                SecondOption = eq.question.SecondOption,
            //                ThirtOption = eq.question.ThirtOption,
            //                FourthOption = eq.question.FourthOption,
            //                CurrentAnswer = eq.question.CurrentAnswer
            //            });




        }
    }
}
