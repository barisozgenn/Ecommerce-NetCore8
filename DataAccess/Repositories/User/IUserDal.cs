using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public interface IUserDal: IEntityRepository<Entities.Concrete.User.User>
	{
	}
    /*public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

        List<User> GetAll();

        User Get(int id);
    }*/
}

