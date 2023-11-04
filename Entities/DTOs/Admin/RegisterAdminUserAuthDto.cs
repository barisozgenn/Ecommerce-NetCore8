using System;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs.Admin
{
	public class RegisterAdminUserAuthDto
	{
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public IFormFile? ProfileImage { get; set; }
    }
}

