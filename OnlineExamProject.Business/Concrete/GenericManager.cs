using OnlineExamProject.Business.Interfaces;
using OnlineExamProject.DataAccesss.Interfaces;
using OnlineExamProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineExamProject.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
      

        public List<TEntity> GetAll()
        {
            return _genericDal.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Save(TEntity entity)
        {
            _genericDal.Save(entity);
        }

        public void Update(TEntity entity)
        {
            _genericDal.Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _genericDal.Delete(entity);
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return _genericDal.List(filter);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _genericDal.Get(filter);
        }
    }
}
