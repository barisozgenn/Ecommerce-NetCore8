using System;
namespace Entities.Concrete.User
{
	public class User
	{
        public int Id { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

