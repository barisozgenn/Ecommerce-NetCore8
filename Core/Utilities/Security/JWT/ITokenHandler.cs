using System;
using Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHandler
    {
        Token CreateToken(AdminUser adminUser, List<AdminRole> adminRoles);
    }
}

