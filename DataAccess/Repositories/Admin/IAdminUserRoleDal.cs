using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
	public interface IAdminUserRoleDal : IEntityRepository<AdminUserRole>
    {
	}
    /*public interface IAdminUserRoleDal
    {
        void Add(AdminUserRole adminUserRole);
        void Update(AdminUserRole adminUserRole);
        void Delete(AdminUserRole adminUserRole);

        List<AdminUserRole> GetAll();

        AdminUserRole Get(int id);
    }*/
}

