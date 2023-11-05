using System;
namespace Entities.DTOs.Admin
{
	public class AdminUserUpdatePasswordDto
	{
        public int UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}

