using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
	public interface IAdminEmailParameterDal : IEntityRepository<AdminEmailParameter>
    {
    }
    /*public interface IAdminEmailParameterDal
    {
        void Add(AdminEmailParameter adminEmailParameter);
        void Update(AdminEmailParameter adminEmailParameter);
        void Delete(AdminEmailParameter adminEmailParameter);

        List<AdminEmailParameter> GetAll();

        AdminEmailParameter Get(int id);
    }*/
}

