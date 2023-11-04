using System;
namespace Entities.Concrete.User
{
	public class User
	{
        public int Id { get; set; }
        public required string Email { get; set; }
        public int Status { get; set; }
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation property to link to UserDetail
        public UserDetail? UserDetail { get; set; }
    }
}

