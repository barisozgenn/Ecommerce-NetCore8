using System;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.DTOs.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AdminUserPasswordValidator : AbstractValidator<AdminUserUpdatePasswordDto>
    {
        private readonly IUserMessageService _userMessageService;

        public AdminUserPasswordValidator(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
            RuleFor(p => p.NewPassword).NotEmpty().WithMessage(_userMessageService.PasswordRequired(LanguageKey.En));
            RuleFor(p => p.NewPassword).Length(min: 6, max: 16).WithMessage(_userMessageService.PasswordMinLength(LanguageKey.En));
            RuleFor(p => p.NewPassword).Matches("[A-Z]").WithMessage(_userMessageService.PasswordUppercase(LanguageKey.En));
            RuleFor(p => p.NewPassword).Matches("[a-z]").WithMessage(_userMessageService.PasswordLowercase(LanguageKey.En));
            RuleFor(p => p.NewPassword).Matches("[0-9]").WithMessage(_userMessageService.PasswordNumber(LanguageKey.En));
            RuleFor(p => p.NewPassword).Matches("[^a-zA-Z0-9]").WithMessage(_userMessageService.PasswordSpecialCharacter(LanguageKey.En));
        }
    }
}

