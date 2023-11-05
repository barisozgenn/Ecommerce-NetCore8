using System;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs.Admin
{
	public class RegisterAdminUserAuthDto
	{
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IFormFile? ProfileImage { get; set; }
    }
}

