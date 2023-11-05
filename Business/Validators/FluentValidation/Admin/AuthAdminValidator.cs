using System;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.DTOs.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AuthAdminValidator : AbstractValidator<RegisterAdminUserAuthDto> //Class adını Validator ile bitirdik çünkü FluentValidation öyle istiyor
    {
        private readonly IUserMessageService _userMessageService;

        public AuthAdminValidator(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;

            RuleFor(p => p.Username).NotEmpty().WithMessage(_userMessageService.GetUsernameRequired(LanguageKey.En));
            RuleFor(p => p.Email).NotEmpty().WithMessage(_userMessageService.GetEmailRequired(LanguageKey.En));
            RuleFor(p => p.Email).EmailAddress().WithMessage(_userMessageService.GetEmailIsNotValid(LanguageKey.En));

            RuleFor(p => p.Password).NotEmpty().WithMessage(_userMessageService.PasswordRequired(LanguageKey.En));
            RuleFor(p => p.Password).Length(min: 6, max: 16).WithMessage(_userMessageService.PasswordMinLength(LanguageKey.En));
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage(_userMessageService.PasswordUppercase(LanguageKey.En));
            RuleFor(p => p.Password).Matches("[a-z]").WithMessage(_userMessageService.PasswordLowercase(LanguageKey.En));
            RuleFor(p => p.Password).Matches("[0-9]").WithMessage(_userMessageService.PasswordNumber(LanguageKey.En));
            RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage(_userMessageService.PasswordSpecialCharacter(LanguageKey.En));
        }

    }
}

