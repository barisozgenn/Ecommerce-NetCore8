using System;
using Entities.Enums;
using System.Net;
using Entities.Concrete.User;

namespace Entities.Concrete.Product
{
	public class ProductOrder
	{
        public int Id { get; set; }

        public required int UserId { get; set; } // Reference to the user who placed the order

        public required List<ProductOrderItem> Items { get; set; } // List of items in the order

        public required UserAddress ShippingAddress { get; set; } // Shipping address for the order

        public required ProductOrderStatus OrderStatus { get; set; } // Order status (e.g., Pending, Shipped, Delivered)

        public required PaymentStatus PaymentStatus { get; set; } // Payment status (e.g., Authorized, Captured, Refunded)
        public required PaymentMethod PaymentMethod { get; set; }

        public DateTime OrderDate { get; set; } // Date and time when the order was placed
        public DateTime UpdatedDate { get; set; } 

        public decimal TotalAmount { get; set; } // Total order amount

        public string? OrderNotes { get; set; } // Additional notes or comments for the order

        public string? InvoiceUrl { get; set; }
    }
}

