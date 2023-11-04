using System;
namespace Business.Utilities.Message
{
    public interface IUserMessageService
    {
        string GetEmailRequired(string languageKey);
        string GetPhoneRequired(string languageKey);
        string GetUsernameRequired(string languageKey);
        string GetPasswordRequired(string languageKey);
        string GetProfileUpdated(string languageKey);
        string GetEmailVerified(string languageKey);
        string GetPhoneVerified(string languageKey);
        string GetAccountLocked(string languageKey);
        string GetAccountUnlocked(string languageKey);
        string GetEmailSent(string languageKey);
        string GetAccountSuspended(string languageKey);
        string GetEmailNotAvailable(string languageKey);
        string GetPhoneNotAvailable(string languageKey);
        string GetUserNotFound(string languageKey);
        string GetPasswordIncorrect(string languageKey);
        string GetEmailAlreadyInUse(string languageKey);
        string GetPhoneAlreadyInUse(string languageKey);
        string GetVerificationCodeExpired(string languageKey);
        string GetAccountDeleted(string languageKey);
        string GetPasswordChanged(string languageKey);
        string GetUnauthorizedAccess(string languageKey);
        string GetProfilePictureUpdated(string languageKey);
        string GetProfilePictureRemoved(string languageKey);
        string GetAccountReactivated(string languageKey);
        string GetAccountDeactivated(string languageKey);
        string GetInvalidEmailAddress(string languageKey);
        string GetInvalidPhoneNumber(string languageKey);
        string GetInvalidUsername(string languageKey);
        string GetEmailUpdated(string languageKey);
        string GetPhoneNumberUpdated(string languageKey);
        string GetAccountSuspendedDueToViolation(string languageKey);
        string GetAccountClosed(string languageKey);
    }
}

