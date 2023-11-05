using System;
using Core.Utilities.Result.Abstract;
using Entities.Concrete.Admin;

namespace Business.Services.Admin
{
    public interface IAdminEmailParameterService
    {
        IResponse Add(AdminEmailParameter adminEmailParameter);
        IResponse Update(AdminEmailParameter adminEmailParameter);
        IResponse Delete(AdminEmailParameter adminEmailParameter);

        IDataResult<List<AdminEmailParameter>> GetList();
        IDataResult<AdminEmailParameter> GetById(int id);

        IResponse SendEmail(AdminEmailParameter adminEmailParameter, string body, string subject, string emails);
    }
}

