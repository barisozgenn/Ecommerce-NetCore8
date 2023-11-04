using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
    public interface IAdminRoleDal : IEntityRepository<AdminRole>
    {
    }
    /*public interface IAdminRoleDal
    {
        void Add(AdminRole adminRole);
        void Update(AdminRole adminRole);
        void Delete(AdminRole adminRole);

        List<AdminRole> GetAll();

        AdminRole Get(int id);
    }*/
}

