using System;
using Core.Utilities.Result.Abstract;
using Entities.Concrete.Admin;

namespace Business.Services.Admin
{
    public interface IAdminUserRoleService
    {
        IResponse Add(AdminUserRole adminUserRole);
        IResponse Update(AdminUserRole adminUserRole);
        IResponse Delete(AdminUserRole adminUserRole);

        IDataResult<List<AdminUserRole>> GetList();
        IDataResult<AdminUserRole> GetById(int id);
    }
}

