using System;
using System.Net;

namespace Entities.Concrete.User
{
	public class UserDetail
	{
        public int Id { get; set; }
        public int UserId { get; set; }

        public required string Name { get; set; }
        public required string Surname { get; set; }

        public string? ImageUrl { get; set; }

        public string? Language { get; set; }

        public string? PhoneCountryCode { get; set; }
        public string? PhoneNumber { get; set; }

        public List<UserAddress>? Addresses { get; set; }

        // Navigation property to link to User
        public User? User { get; set; }
    }
}

