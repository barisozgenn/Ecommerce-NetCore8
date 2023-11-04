using System;
namespace Business.Utilities.Message
{
	public interface IAdminMessageService
    {
        string GetStmpNull(string languageKey);
        string GetPortNull(string languageKey);
        string GetEmailNull(string languageKey);
        string GetPasswordNull(string languageKey);
        string GetSSLNull(string languageKey);
        string GetEmailParameterAdded(string languageKey);
        string GetEmailParameterUpdated(string languageKey);
        string GetEmailParameterDeleted(string languageKey);
        string GetEmailSent(string languageKey);
        string GetRoleNameMustBeFilled(string languageKey);
        string GetRoleAdded(string languageKey);
        string GetRoleUpdated(string languageKey);
        string GetRoleRemoved(string languageKey);
        string GetRoleNameIsAddedAlready(string languageKey);
        string GetRoleNameIsOk(string languageKey);
        string GetUpdatedUser(string languageKey);
        string GetDeletedUser(string languageKey);
        string GetPasswordCurrentWrong(string languageKey);
        string GetPasswordUpdated(string languageKey);
        string GetUsernameOrPasswordWrong(string languageKey);
        string GetSelectUser(string languageKey);
        string GetSelectRole(string languageKey);
        string GetUserRoleAdded(string languageKey);
        string GetUserRoleUpdated(string languageKey);
        string GetUserRoleRemoved(string languageKey);
        string GetRoleNameIsNotFound(string languageKey);
        string GetUserIsNotFound(string languageKey);
        string GetRoleNameIsAlreadyAdded(string languageKey);
    }

}

