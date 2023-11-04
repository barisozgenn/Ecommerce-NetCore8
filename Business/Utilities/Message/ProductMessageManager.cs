using System;
namespace Business.Utilities.Message
{
	public class ProductMessageManager: IProductMessageManager
    {
        public string GetProductAdded(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Product is added." },
        { "tr", "Ürün eklendi." }
    }[languageKey];

        public string GetProductUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Product is updated." },
        { "tr", "Ürün güncellendi." }
    }[languageKey];

        public string GetProductRemoved(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Product is removed." },
        { "tr", "Ürün kaldırıldı." }
    }[languageKey];

        public string GetOrderPlaced(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is placed." },
        { "tr", "Sipariş verildi." }
    }[languageKey];

        public string GetOrderUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is updated." },
        { "tr", "Sipariş güncellendi." }
    }[languageKey];

        public string GetOrderCanceled(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is canceled." },
        { "tr", "Sipariş iptal edildi." }
    }[languageKey];

        public string GetPaymentReceived(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment received." },
        { "tr", "Ödeme alındı." }
    }[languageKey];

        public string GetPaymentFailed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment failed." },
        { "tr", "Ödeme başarısız oldu." }
    }[languageKey];

        public string GetShipmentScheduled(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment scheduled." },
        { "tr", "Gönderim planlandı." }
    }[languageKey];

        public string GetShipmentDelayed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment delayed." },
        { "tr", "Gönderim gecikti." }
    }[languageKey];

        public string GetAddressUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address is updated." },
        { "tr", "Adres güncellendi." }
    }[languageKey];

        public string GetAddressAdded(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address is added." },
        { "tr", "Adres ekledi." }
    }[languageKey];

        public string GetAddressRemoved(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address is removed." },
        { "tr", "Adres kaldırıldı." }
    }[languageKey];

        public string GetAddressNotFound(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address not found." },
        { "tr", "Adres bulunamadı." }
    }[languageKey];

        public string GetOrderStatusChanged(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order status changed." },
        { "tr", "Sipariş durumu değiştirildi." }
    }[languageKey];

        public string GetPaymentPending(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment is pending." },
        { "tr", "Ödeme beklemede." }
    }[languageKey];

        public string GetShipmentDelivered(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment is delivered." },
        { "tr", "Gönderim teslim edildi." }
    }[languageKey];

        public string GetPaymentSuccessful(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment is successful." },
        { "tr", "Ödeme başarılı." }
    }[languageKey];

        public string GetPaymentCancelled(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment is cancelled." },
        { "tr", "Ödeme iptal edildi." }
    }[languageKey];

        public string GetShipmentTrackingNumberUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment tracking number is updated." },
        { "tr", "Gönderim takip numarası güncellendi." }
    }[languageKey];

        public string GetShipmentLost(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment is lost." },
        { "tr", "Gönderim kayboldu." }
    }[languageKey];

        public string GetPaymentRefunded(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment refunded." },
        { "tr", "Ödeme iade edildi." }
    }[languageKey];

        public string GetPaymentAuthorizationFailed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment authorization failed." },
        { "tr", "Ödeme yetkilendirme başarısız." }
    }[languageKey];

        public string GetShipmentInProgress(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment is in progress." },
        { "tr", "Gönderim devam ediyor." }
    }[languageKey];

        public string GetAddressNotValid(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address is not valid." },
        { "tr", "Adres geçerli değil." }
    }[languageKey];

        public string GetOrderNotEligibleForCancellation(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is not eligible for cancellation." },
        { "tr", "Sipariş iptal için uygun değil." }
    }[languageKey];

        public string GetPaymentAuthorizationExpired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment authorization expired." },
        { "tr", "Ödeme yetkilendirmesi süresi doldu." }
    }[languageKey];

        public string GetShipmentDelayedDueToWeather(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment delayed due to weather conditions." },
        { "tr", "Hava koşulları nedeniyle gönderim gecikti." }
    }[languageKey];

    public string GetAddressFormatInvalid(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address format is invalid." },
        { "tr", "Adres formatı geçersiz." }
    }[languageKey];

        public string GetOrderProcessing(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is being processed." },
        { "tr", "Sipariş işleniyor." }
    }[languageKey];

        public string GetPaymentDeclined(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment is declined." },
        { "tr", "Ödeme reddedildi." }
    }[languageKey];

        public string GetShipmentDelayedDueToTraffic(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment delayed due to traffic." },
        { "tr", "Trafik nedeniyle gönderim gecikti." }
    }[languageKey];

        public string GetAddressAddedSuccessfully(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address added successfully." },
        { "tr", "Adres başarıyla eklendi." }
    }[languageKey];

        public string GetOrderReadyForPickup(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order is ready for pickup." },
        { "tr", "Sipariş teslim almaya hazır." }
    }[languageKey];

        public string GetPaymentProcessing(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment is being processed." },
        { "tr", "Ödeme işleniyor." }
    }[languageKey];

        public string GetShipmentStuckInCustoms(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment is stuck in customs." },
        { "tr", "Gönderim gümrükte takıldı." }
    }[languageKey];

        public string GetAddressVerificationFailed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address verification failed." },
        { "tr", "Adres doğrulama başarısız." }
    }[languageKey];

        public string GetOrderDeliveryFailed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order delivery failed." },
        { "tr", "Sipariş teslimatı başarısız." }
    }[languageKey];
        public string GetProductUpdatedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Product updated by admin." },
        { "tr", "Ürün admin tarafından güncellendi." }
    }[languageKey];

        public string GetOrderUpdatedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order updated by admin." },
        { "tr", "Sipariş admin tarafından güncellendi." }
    }[languageKey];

        public string GetPaymentUpdatedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment updated by admin." },
        { "tr", "Ödeme admin tarafından güncellendi." }
    }[languageKey];

        public string GetShipmentUpdatedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment updated by admin." },
        { "tr", "Gönderim admin tarafından güncellendi." }
    }[languageKey];

        public string GetAddressUpdatedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address updated by admin." },
        { "tr", "Adres admin tarafından güncellendi." }
    }[languageKey];

        public string GetProductRemovedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Product removed by admin." },
        { "tr", "Ürün admin tarafından kaldırıldı." }
    }[languageKey];

        public string GetOrderRemovedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Order removed by admin." },
        { "tr", "Sipariş admin tarafından kaldırıldı." }
    }[languageKey];

        public string GetPaymentRemovedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Payment removed by admin." },
        { "tr", "Ödeme admin tarafından kaldırıldı." }
    }[languageKey];

        public string GetShipmentRemovedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Shipment removed by admin." },
        { "tr", "Gönderim admin tarafından kaldırıldı." }
    }[languageKey];

        public string GetAddressRemovedByAdmin(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Address removed by admin." },
        { "tr", "Adres admin tarafından kaldırıldı." }
    }[languageKey];

    }
}

