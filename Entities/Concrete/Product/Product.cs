using System;
using System.ComponentModel.DataAnnotations;
using Entities.Enums;

namespace Entities.Concrete.Product
{
    public class Product
    {
        public int Id { get; set; }
        // A dictionary of name in different languages
        public Dictionary<string, string>? Names { get; set; }
        // A dictionary of descriptions in different languages
        public Dictionary<string, string>? Descriptions { get; set; }

        public required decimal Price { get; set; }
        public required decimal DiscountedPrice { get; set; } // Price after any discounts
        public required string Currency { get; set; } // Currency code (e.g., USD, EUR)

        public required decimal Tax { get; set; } // You can adjust this according to your tax requirements
        public required bool TaxIncluded { get; set; } // True if tax is included in the price

        public string? Brand { get; set; }

        [Range(0, int.MaxValue)]
        public int? StockQuantity { get; set; }
        public required bool IsAvailable { get; set; }

        // Product Category (assuming a many-to-many relationship)
        public required List<ProductCategory> Categories { get; set; }

        // A collection of image URLs for the product
        public required List<string> ImageUrls { get; set; }

        // A collection of video URLs for the product
        public List<string>? VideoUrls { get; set; }

      
        public required List<PaymentMethod> AvailablePaymentMethods { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

