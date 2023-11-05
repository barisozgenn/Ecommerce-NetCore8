using System;
using Core.Utilities.Result.Abstract;
using Entities.Concrete.Admin;
using Entities.DTOs.Admin;

namespace Business.Services.Admin
{
    public interface IAdminUserService
    {
        void Add(RegisterAdminUserAuthDto registerDto);

        IResponse Update(AdminUser adminUser);
        IResponse UpdatePassword(AdminUserUpdatePasswordDto adminUserUpdatePasswordDto);

        IResponse Delete(AdminUser adminUser);

        IDataResult<List<AdminUser>> GetList();

        AdminUser GetByEmail(string email);
        AdminUser GetByUsername(string username);

        List<AdminRole> GetAdminRoles(int userId);

        IDataResult<AdminUser> GetById(int id);
    }
}

