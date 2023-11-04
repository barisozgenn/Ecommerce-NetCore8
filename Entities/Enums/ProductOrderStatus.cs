using System;
namespace Entities.Enums
{
	public enum ProductOrderStatus
	{
        Pending,
        Processing,
        Shipped,
        Delivered,
        CanceledByAdmin,
        CanceledByUser,
        Returned,
        Completed
    }
}

