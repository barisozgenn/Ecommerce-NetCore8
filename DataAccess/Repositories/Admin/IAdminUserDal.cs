using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
	public interface IAdminUserDal : IEntityRepository<AdminUser>
    {
	}
    /*public interface IAdminUserDal
    {
        void Add(AdminUser adminUser);
        void Update(AdminUser adminUser);
        void Delete(AdminUser adminUser);

        List<AdminUser> GetAll();

        AdminUser Get(int id);
    }*/
}

