using System;
namespace Entities.Concrete.Admin
{
	public class AdminUser
	{
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public string? ImageUrl { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }

        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

