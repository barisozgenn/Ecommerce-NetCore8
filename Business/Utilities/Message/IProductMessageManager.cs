using System;
namespace Business.Utilities.Message
{
    public interface IProductMessageManager
    {
        string GetProductAdded(string languageKey);
        string GetProductUpdated(string languageKey);
        string GetProductRemoved(string languageKey);
        string GetOrderPlaced(string languageKey);
        string GetOrderUpdated(string languageKey);
        string GetOrderCanceled(string languageKey);
        string GetPaymentReceived(string languageKey);
        string GetPaymentFailed(string languageKey);
        string GetShipmentScheduled(string languageKey);
        string GetShipmentDelayed(string languageKey);
        string GetAddressUpdated(string languageKey);
        string GetAddressAdded(string languageKey);
        string GetAddressRemoved(string languageKey);
        string GetAddressNotFound(string languageKey);
        string GetOrderStatusChanged(string languageKey);
        string GetPaymentPending(string languageKey);
        string GetShipmentDelivered(string languageKey);
        string GetPaymentSuccessful(string languageKey);
        string GetPaymentCancelled(string languageKey);
        string GetShipmentTrackingNumberUpdated(string languageKey);
        string GetShipmentLost(string languageKey);
        string GetPaymentRefunded(string languageKey);
        string GetPaymentAuthorizationFailed(string languageKey);
        string GetShipmentInProgress(string languageKey);
        string GetAddressNotValid(string languageKey);
        string GetOrderNotEligibleForCancellation(string languageKey);
        string GetPaymentAuthorizationExpired(string languageKey);
        string GetShipmentDelayedDueToWeather(string languageKey);
        string GetAddressFormatInvalid(string languageKey);
        string GetOrderProcessing(string languageKey);
        string GetPaymentDeclined(string languageKey);
        string GetShipmentDelayedDueToTraffic(string languageKey);
        string GetAddressAddedSuccessfully(string languageKey);
        string GetOrderReadyForPickup(string languageKey);
        string GetPaymentProcessing(string languageKey);
        string GetShipmentStuckInCustoms(string languageKey);
        string GetAddressVerificationFailed(string languageKey);
        string GetOrderDeliveryFailed(string languageKey);
        string GetProductUpdatedByAdmin(string languageKey);
        string GetOrderUpdatedByAdmin(string languageKey);
        string GetPaymentUpdatedByAdmin(string languageKey);
        string GetShipmentUpdatedByAdmin(string languageKey);
        string GetAddressUpdatedByAdmin(string languageKey);
        string GetProductRemovedByAdmin(string languageKey);
        string GetOrderRemovedByAdmin(string languageKey);
        string GetPaymentRemovedByAdmin(string languageKey);
        string GetShipmentRemovedByAdmin(string languageKey);
        string GetAddressRemovedByAdmin(string languageKey);
    }

}

