using System;
namespace Entities.DTOs.Admin
{
	public class AdminUserUpdatePasswordDto
	{
        public int UserId { get; set; }
        public required string CurrentPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}

