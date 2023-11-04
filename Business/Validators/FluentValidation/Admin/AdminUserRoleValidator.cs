using Business.Utilities.Constants;
using Business.Utilities.Message;
using Entities.Concrete.Admin;
using FluentValidation;

namespace Business.Validators.FluentValidation.Admin
{
    public class AdminUserRoleValidator : AbstractValidator<AdminUserRole>
    {
        private readonly IAdminMessageService _adminMessageService;

        public AdminUserRoleValidator(IAdminMessageService adminMessageService)
        {
            _adminMessageService = adminMessageService;

            RuleFor(p => p.AdminId).Must(IsIdValid).WithMessage(_adminMessageService.GetSelectRole(LanguageKey.En));//int leri default 0 algılıyor gönderince boş ta olmasın tabi
            //RuleFor(p => p.RoleId).NotEmpty().GreaterThan(0).WithMessage(MessagesAdminUserRole.SelectRole);
            RuleFor(p => p.RoleId).Must(IsIdValid).WithMessage(_adminMessageService.GetSelectRole(LanguageKey.En));
        }

        public bool IsIdValid(int id = 0)
        {
            if (id > 0) return true;
            else return false;
        }
    }
}

