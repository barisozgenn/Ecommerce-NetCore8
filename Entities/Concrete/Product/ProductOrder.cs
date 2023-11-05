using System;
using Entities.Enums;
using System.Net;
using Entities.Concrete.User;

namespace Entities.Concrete.Product
{
	public class ProductOrder
	{
        public int Id { get; set; }

        public int UserId { get; set; } // Reference to the user who placed the order

        public List<ProductOrderItem>? Items { get; set; } // List of items in the order

        public UserAddress? ShippingAddress { get; set; } // Shipping address for the order

        public ProductOrderStatus OrderStatus { get; set; } // Order status (e.g., Pending, Shipped, Delivered)

        public PaymentStatus PaymentStatus { get; set; } // Payment status (e.g., Authorized, Captured, Refunded)
        public PaymentMethod PaymentMethod { get; set; }

        public decimal TotalAmount { get; set; } // Total order amount

        public string? OrderNotes { get; set; } // Additional notes or comments for the order

        public string? InvoiceUrl { get; set; }

        public string? ShippingCompany { get; set; }
        public string? ShippingTrackId { get; set; }
        public string? ShippingTrackUrl { get; set; }

        public DateTime OrderDate { get; set; } // Date and time when the order was placed
        public DateTime UpdatedDate { get; set; }
    }
}

