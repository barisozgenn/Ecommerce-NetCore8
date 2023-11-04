using System;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.Concrete.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AdminEmailParameterValidator : AbstractValidator<AdminEmailParameter>
    {
        private readonly IAdminMessageService _adminMessageService;
        public AdminEmailParameterValidator(IAdminMessageService adminMessageService)
        {
            _adminMessageService = adminMessageService;
            RuleFor(p => p.Smtp).NotEmpty().WithMessage(_adminMessageService.GetStmpNull(LanguageKey.En));
            RuleFor(p => p.Email).NotEmpty().WithMessage(_adminMessageService.GetEmailNull(LanguageKey.En));
            RuleFor(p => p.Password).NotEmpty().WithMessage(_adminMessageService.GetPasswordNull(LanguageKey.En));
            RuleFor(p => p.Port).NotEmpty().GreaterThan(0).WithMessage(_adminMessageService.GetPortNull(LanguageKey.En));
            RuleFor(p => p.SSL).NotEmpty().WithMessage(_adminMessageService.GetSSLNull(LanguageKey.En));
        }

    }
}

