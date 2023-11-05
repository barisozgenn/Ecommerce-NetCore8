using System;
namespace Entities.Concrete.Product
{
	public class ProductOrderItem
	{
        public int Id { get; set; }
        public int OrderId { get; set; } // Foreign key
        public int ProductId { get; set; } // Reference to the product in the order
        public decimal UnitPrice { get; set; } // Price per unit
        public decimal TotalPrice { get; set; } // Total price for the line item
        public string Currency { get; set; } // Currency code (e.g., USD, EUR)
        public decimal Tax { get; set; } // You can adjust this according to your tax requirements
        public bool TaxIncluded { get; set; } // True if tax is included in the price
        public int Quantity { get; set; } // Number of units ordered
    }
}

