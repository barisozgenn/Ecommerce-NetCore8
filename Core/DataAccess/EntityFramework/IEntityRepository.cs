using System;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> //<T> generic object
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAll(Expression<Func<T, bool>>? filter = null);//we defined generic optional type to filter it easily

        T? Get(Expression<Func<T, bool>> filter);//we defined generic optional type to filter it easily
    }
    //if we did not make it generic
    /*
        public interface IEntityRepository
        {
            void Add(User user);
            void Update(User user);
            void Delete(User user);
            List<User> GetAll();
            User Get(int id);
        }
     */
}

