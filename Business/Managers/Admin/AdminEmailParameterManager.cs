using System;
using Business.Services.Admin;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.Admin;
using Entities.Concrete.Admin;
using System.Net;
using System.Net.Mail;
using Business.Utilities.Message;
using Business.Utilities.Constants;

namespace Business.Managers.Admin
{
    public class AdminEmailParameterManager : IAdminEmailParameterService
    {
        private readonly IAdminEmailParameterDal _adminEmailParameterDal;
        private readonly IAdminMessageService _adminMessageService;

        public AdminEmailParameterManager(IAdminEmailParameterDal adminEmailParameterDal, IAdminMessageService adminMessageService)
        {
            _adminEmailParameterDal = adminEmailParameterDal;//dependency leri ekle AutofacBusinessModule içine
            _adminMessageService = adminMessageService;
        }

        public IResponse Add(AdminEmailParameter adminEmailParameter)
        {
            _adminEmailParameterDal.Add(adminEmailParameter);
            return new ResponseSuccess(statusText: _adminMessageService.GetEmailParameterAdded(LanguageKey.En));

        }

        public IResponse Delete(AdminEmailParameter adminEmailParameter)
        {
            _adminEmailParameterDal.Delete(adminEmailParameter);
            return new ResponseSuccess(statusText: _adminMessageService.GetEmailParameterDeleted(LanguageKey.En));
        }

        public IDataResult<AdminEmailParameter> GetById(int id)
        {
            return new DataResultSuccess<AdminEmailParameter>(data: _adminEmailParameterDal.Get(p => p.Id == id), statusText: "success");
        }

        public IDataResult<List<AdminEmailParameter>> GetList()
        {
            return new DataResultSuccess<List<AdminEmailParameter>>(data: _adminEmailParameterDal.GetAll(), statusText: "success");
        }

        public IResponse SendEmail(AdminEmailParameter adminEmailParameter, string body, string subject, string emails)
        {
            using (MailMessage mail = new MailMessage())
            {
                string[] emailsTo = emails.Split(",");
                mail.From = new MailAddress(address: adminEmailParameter.Email);

                foreach (var itemEmail in emailsTo)
                {
                    mail.To.Add(itemEmail.Replace(" ", ""));
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = adminEmailParameter.Html;
                //mail.Attachments.Add();

                using (SmtpClient smtp = new SmtpClient(host: adminEmailParameter.Email))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(userName: adminEmailParameter.Email, password: adminEmailParameter.Password);
                    smtp.EnableSsl = adminEmailParameter.SSL;
                    smtp.Port = adminEmailParameter.Port;
                    smtp.Send(mail);
                }
            }
            return new ResponseSuccess(statusText: _adminMessageService.GetEmailSent(LanguageKey.En).Replace("xxx_username", emails));
        }

        public IResponse Update(AdminEmailParameter adminEmailParameter)
        {
            _adminEmailParameterDal.Update(adminEmailParameter);
            return new ResponseSuccess(statusText: _adminMessageService.GetEmailParameterUpdated(LanguageKey.En));
        }
    }
}

