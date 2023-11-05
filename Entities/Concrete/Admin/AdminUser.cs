using System;
namespace Entities.Concrete.Admin
{
	public class AdminUser
	{
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? ImageUrl { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }

        public  byte[]? PasswordHash { get; set; }
        public  byte[]? PasswordSalt { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

