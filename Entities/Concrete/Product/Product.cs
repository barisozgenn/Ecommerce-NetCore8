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

        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; } // Price after any discounts
        public string? Currency { get; set; } // Currency code (e.g., USD, EUR)

        public decimal Tax { get; set; } // You can adjust this according to your tax requirements
        public bool TaxIncluded { get; set; } // True if tax is included in the price

        public string? Brand { get; set; }

        [Range(0, int.MaxValue)]
        public int? StockQuantity { get; set; }
        public bool IsAvailable { get; set; }

        // Product Category (assuming a many-to-many relationship)
        public List<ProductCategory>? Categories { get; set; }

        // A collection of image URLs for the product
        public List<string>? ImageUrls { get; set; }

        // A collection of video URLs for the product
        public List<string>? VideoUrls { get; set; }

      
        public List<PaymentMethod>? AvailablePaymentMethods { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

