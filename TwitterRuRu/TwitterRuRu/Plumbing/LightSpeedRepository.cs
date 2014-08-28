using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TwitterRuRu.Models;


namespace TwitterRuRu.Plumbing
{
    public class Repository<T> : IDisposable where T : Entity<int>
    {
        public Repository()
        {
            var context = new LightSpeedContext<LightSpeedModel1UnitOfWork>();
            context.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            context.IdentityMethod = IdentityMethod.IdentityColumn;

            _unitOfWork = context.CreateUnitOfWork();
        }
        private readonly IUnitOfWork _unitOfWork;

        public IList<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Query<T>().Where(predicate).ToList();
        }

        public IList<T> GetAll()
        {
            return _unitOfWork.Find<T>();
        }

        public void Add(T entity)
        {
            _unitOfWork.Add(entity);
        }

        public void DeleteAll()
        {
            foreach (var entity in GetAll())
            {
                Delete(entity);
            }
        }

        public void Delete(T entity)
        {
            _unitOfWork.Remove(entity);
        }

        public T FindById(int id)
        {
            return _unitOfWork.FindById<T>(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}