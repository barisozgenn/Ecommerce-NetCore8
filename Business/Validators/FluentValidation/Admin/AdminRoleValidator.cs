using System;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.Concrete.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AdminRoleValidator : AbstractValidator<AdminRole>
    {
        private readonly IAdminMessageService _adminMessageService;
        public AdminRoleValidator(IAdminMessageService adminMessageService)
        {
            _adminMessageService = adminMessageService;
            RuleFor(p => p.Name).NotEmpty().WithMessage(_adminMessageService.GetRoleNameMustBeFilled(LanguageKey.En));
        }
    }
}

