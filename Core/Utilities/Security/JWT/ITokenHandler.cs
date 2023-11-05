using System;
using Entities.Concrete;
using Entities.Concrete.Admin;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHandler
    {
        Token CreateToken(AdminUser adminUser, List<AdminRole> adminRoles);
    }
}

