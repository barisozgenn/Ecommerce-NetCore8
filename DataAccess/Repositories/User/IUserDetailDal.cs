using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public interface IUserDetailDal : IEntityRepository<UserDetail>
    {
    }
    /*public interface IUserDetailDal
    {
        void Add(UserDetail userDetail);
        void Update(UserDetail userDetail);
        void Delete(UserDetail userDetail);

        List<UserDetail> GetAll();

        UserDetail Get(int id);
    }*/
}

