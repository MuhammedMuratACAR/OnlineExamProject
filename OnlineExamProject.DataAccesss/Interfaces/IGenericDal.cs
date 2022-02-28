using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineExamProject.DataAccesss.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        List<TEntity> List(Expression<Func<TEntity, bool>> filter);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Save(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
