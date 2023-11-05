using System;
using Business.Aspects.Secured;
using Business.Services.Admin;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Business.Validators.FluentValidation.Admin;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.Admin;
using Entities.Concrete.Admin;

namespace Business.Managers.Admin
{
    public class AdminRoleManager : IAdminRoleService //Depenceny Incetion yapacağız program.cs de ki web api den interfaceleri çağırabilelim
    {
        private readonly IAdminRoleDal _adminRoleDal;
        private readonly IAdminMessageService _adminMessageService;

        public AdminRoleManager(IAdminRoleDal adminRoleDal, IAdminMessageService adminMessageService)//ctor tab tab ile constructor oluşturduk böylece programda new leme ve ağırlık yapmadan IAdminRoleDal kullanabilicek kıvamda eşleştirdik
        {
            _adminRoleDal = adminRoleDal;
            _adminMessageService = adminMessageService;
        }

        [ValidationAspect(typeof(AdminRoleValidator))]
        [CacheAspectRemove("IAdminRoleService.GetList")]//ekleme işlemi yapınca cache i temizleyelim
        public IResponse Add(AdminRole adminRole)
        {
            IResponse response = BusinessRules.Run(IsAdminRoleAvailable(name: adminRole.Name));

            if (response.Status)
            {
                _adminRoleDal.Add(adminRole);
                return new ResponseSuccess(statusText: _adminMessageService.GetRoleAdded(LanguageKey.En));
            }
            else return response;

        }

        public IResponse Delete(AdminRole adminRole)
        {
            _adminRoleDal.Delete(adminRole);
            return new ResponseSuccess(statusText: _adminMessageService.GetRoleRemoved(LanguageKey.En));
        }

        public IDataResult<AdminRole> GetById(int id)
        {
            return new DataResultSuccess<AdminRole>(data: _adminRoleDal.Get(p => p.Id == id), statusText: "success");
        }

        [SecuredAspect("Super Admin, Admin")]//hangi role izin vereceksek adını yaz ", " veya anlamına gelir
        [CacheAspect(duration: 60)]
        [PerformanceAspect(interval: 0)]//bu servis dönüşü 2 sn geçiyorsa log la
        public IDataResult<List<AdminRole>> GetList()
        {
            return new DataResultSuccess<List<AdminRole>>(data: _adminRoleDal.GetAll(), statusText: "success");
        }

        [ValidationAspect(typeof(AdminRoleValidator))]
        [SecuredAspect()]
        public IResponse Update(AdminRole adminRole)
        {
            IResponse response = BusinessRules.Run(IsAdminRoleAvailableForUpdate(adminRole: adminRole));

            if (response.Status)
            {
                _adminRoleDal.Update(adminRole);
                return new ResponseSuccess(statusText: _adminMessageService.GetRoleUpdated(LanguageKey.En));
            }
            else return response;


        }

        private IResponse IsAdminRoleAvailable(string name)
        {
            var result = _adminRoleDal.Get(p => p.Name == name);
            if (result != null) return new ResponseFailure(statusText: _adminMessageService.GetRoleNameIsAlreadyAdded(LanguageKey.En));
            else return new ResponseSuccess(statusText: _adminMessageService.GetRoleNameIsOk(LanguageKey.En));
        }
        private IResponse IsAdminRoleAvailableForUpdate(AdminRole adminRole)
        {
            var result = _adminRoleDal.Get(p => p.Name == adminRole.Name && p.Id != adminRole.Id);
            if (result != null) return new ResponseFailure(statusText: _adminMessageService.GetRoleNameIsAlreadyAdded(LanguageKey.En));
            else return new ResponseSuccess(statusText: _adminMessageService.GetRoleNameIsOk(LanguageKey.En));
        }
    }
}

