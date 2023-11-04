using System;
using Business.Services.Admin;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Business.Validators.FluentValidation.Admin;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.Admin;
using Entities.Concrete.Admin;

namespace Business.Managers.Admin
{
    public class AdminUserRoleManager
    {
        public class AdminUserRoleManager : IAdminUserRoleService //Depenceny Incetion yapacağız program.cs de ki web api den interfaceleri çağırabilelim
        {
            private readonly IAdminUserRoleDal _adminUserRoleDal;
            private readonly IAdminRoleService _adminRoleService;
            private readonly IAdminUserService _adminUserService;
            private readonly IAdminMessageService _adminMessageService;

            public AdminUserRoleManager(IAdminUserRoleDal adminUserRoleDal, IAdminRoleService adminRoleService, IAdminUserService adminUserService, IAdminMessageService adminMessageService)//ctor tab tab ile constructor oluşturduk böylece programda new leme ve ağırlık yapmadan IAdminUserRoleDal kullanabilicek kıvamda eşleştirdik
            {
                _adminUserRoleDal = adminUserRoleDal;
                _adminRoleService = adminRoleService;
                _adminUserService = adminUserService;
                _adminMessageService = adminMessageService;
            }

            [ValidationAspect(typeof(AdminUserRoleValidator))]
            public IResponse Add(AdminUserRole adminUserRole)
            {
                IResponse response = BusinessRules.Run(
                    IsAdminUserRoleAvailable(roleId: adminUserRole.RoleId, adminId: adminUserRole.AdminId),
                    IsAdminRoleExist(roleId: adminUserRole.RoleId),
                    IsAdminUserExist(userId: adminUserRole.AdminId)
                    );

                if (response.Status)
                {
                    _adminUserRoleDal.Add(adminUserRole);
                    return new ResponseSuccess(statusText: _adminMessageService.GetUserRoleAdded(LanguageKey.En));
                }
                else return response;

            }

            public IResponse Delete(AdminUserRole adminUserRole)
            {
                _adminUserRoleDal.Delete(adminUserRole);
                return new ResponseSuccess(statusText: _adminMessageService.GetUserRoleRemoved(LanguageKey.En));
            }

            public IDataResult<AdminUserRole> GetById(int id)
            {
                return new DataResultSuccess<AdminUserRole>(data: _adminUserRoleDal.Get(p => p.Id == id), statusText: "ok");
            }

            public IDataResult<List<AdminUserRole>> GetList()
            {
                return new DataResultSuccess<List<AdminUserRole>>(data: _adminUserRoleDal.GetAll(), statusText: "ok");
            }

            [ValidationAspect(typeof(AdminUserRoleValidator))]
            public IResponse Update(AdminUserRole adminUserRole)
            {
                _adminUserRoleDal.Update(adminUserRole);
                return new ResponseSuccess(statusText: _adminMessageService.GetUserRoleUpdated(LanguageKey.En));
            }

            private IResponse IsAdminUserRoleAvailable(int roleId, int adminId)
            {
                var result = _adminUserRoleDal.Get(p => p.AdminId == adminId && p.RoleId == roleId);
                if (result != null) return new ResponseFailure(statusText: _adminMessageService.GetRoleNameIsAlreadyAdded(LanguageKey.En));
                else return new ResponseSuccess(statusText: _adminMessageService.GetRoleNameIsOk(LanguageKey.En));
            }
            private IResponse IsAdminRoleExist(int roleId)
            {
                var result = _adminRoleService.GetById(id: roleId).Data;//dataresult döndüyor data almamız lazım
                if (result == null) return new ResponseFailure(statusText: _adminMessageService.GetRoleNameIsNotFound(LanguageKey.En));
                else return new ResponseSuccess(statusText: _adminMessageService.GetRoleNameIsOk(LanguageKey.En));
            }
            private IResponse IsAdminUserExist(int userId)
            {
                var result = _adminUserService.GetById(id: userId).Data;//dataresult döndüyor data almamız lazım
                if (result == null) return new ResponseFailure(statusText: _adminMessageService.GetUserIsNotFound(LanguageKey.En));
                else return new ResponseSuccess(statusText: _adminMessageService.GetRoleNameIsOk(LanguageKey.En));
            }
        }
    }
}

