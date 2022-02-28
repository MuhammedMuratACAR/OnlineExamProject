using OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Context;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineExamProject.DataAccesss.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {

        public List<TEntity> GetAll()
        {
            using var context = new OnlineExamContextDb();
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            using var context = new OnlineExamContextDb();
            return context.Set<TEntity>().Find(id);
        }

        public void Save(TEntity entity)
        {
            using var context = new OnlineExamContextDb();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();

        }

        public void Update(TEntity entity)
        {
            using var context = new OnlineExamContextDb();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new OnlineExamContextDb();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new OnlineExamContextDb();
            return context.Set<TEntity>().Where(filter).ToList();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new OnlineExamContextDb();
            return context.Set<TEntity>().FirstOrDefault(filter);
        }
      
    }
}
