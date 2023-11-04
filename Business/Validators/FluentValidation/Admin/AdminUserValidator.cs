using System;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.Concrete.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AdminUserValidator : AbstractValidator<AdminUser>
    {
        private readonly IUserMessageService _userMessageService;

        public AdminUserValidator(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;

            RuleFor(p => p.Username).NotEmpty().WithMessage(_userMessageService.GetUsernameRequired(LanguageKey.En));
            RuleFor(p => p.Email).NotEmpty().WithMessage(_userMessageService.GetEmailRequired(LanguageKey.En));
            RuleFor(p => p.Email).EmailAddress().WithMessage(_userMessageService.GetEmailIsNotValid(LanguageKey.En));

        }
    }
}

