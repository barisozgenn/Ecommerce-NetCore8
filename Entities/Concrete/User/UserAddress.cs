using System;
namespace Entities.Concrete.User
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Country { get; set; }
        public string? State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string? PostalCode { get; set; }
        public string BuildingNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? Region { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}

