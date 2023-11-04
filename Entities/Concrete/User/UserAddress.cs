using System;
namespace Entities.Concrete.User
{
    public class UserAddress
    {
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required string Country { get; set; }
        public string? State { get; set; }
        public required string City { get; set; }
        public required string Street { get; set; }
        public string? PostalCode { get; set; }
        public required string BuildingNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? Region { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}

