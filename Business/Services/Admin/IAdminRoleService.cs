using System;
using Core.Utilities.Result.Abstract;
using Entities.Concrete.Admin;

namespace Business.Services.Admin
{
    public interface IAdminRoleService
    {
        IResponse Add(AdminRole adminRole);
        IResponse Update(AdminRole adminRole);
        IResponse Delete(AdminRole adminRole);

        IDataResult<List<AdminRole>> GetList();
        IDataResult<AdminRole> GetById(int id);
    }
}

