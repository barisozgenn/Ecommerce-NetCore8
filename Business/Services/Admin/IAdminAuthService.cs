using System;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Security.JWT;
using Entities.DTOs.Admin;

namespace Business.Services.Admin
{
	public interface IAdminAuthService
	{
        IResponse RegisterByAdmin(RegisterAdminUserAuthDto registerDto);
        IDataResult<Token> Login(LoginAdminUserAuthDto loginDto);
    }
}

