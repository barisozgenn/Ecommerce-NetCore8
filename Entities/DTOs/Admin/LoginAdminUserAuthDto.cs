using System;
namespace Entities.DTOs.Admin
{
	public class LoginAdminUserAuthDto
	{
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}

