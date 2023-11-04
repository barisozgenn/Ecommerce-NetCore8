using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public interface IUserAddressDal : IEntityRepository<UserAddress>
    {
    }
    /*public interface IUserAddressDal
    {
        void Add(UserAddress userAddress);
        void Update(UserAddress userAddress);
        void Delete(UserAddress userAddress);

        List<UserAddress> GetAll();

        UserAddress Get(int id);
    }*/
}

