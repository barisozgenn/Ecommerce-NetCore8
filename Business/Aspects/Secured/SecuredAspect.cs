using System;
using Microsoft.AspNetCore.Http;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Aspects.Secured
{
    public class SecuredAspect : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;


        public SecuredAspect()//tokenda parametre aramayıp sadece token var mı diye bakacaksak
        {
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }
        public SecuredAspect(string roles)//tokenda parametrelerde role arayacaksak
        {
            _roles = roles.Split(",");
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        //business katmanında manager method öncesi çağır  [SecuredAspect("Super Admin, Admin")]//hangi role izin vereceksek adını yaz ", " veya anlamına gelir. rol istemiyorsa stringi sil
        protected override void OnBefore(IInvocation invocation)
        {
            if (_roles == null)
            {
                var claims = _httpContextAccessor.HttpContext.User.Claims;
                if (claims.Count() > 0) return;
                throw new Exception("You are Unauthorized for this request");
            }
            else
            {
                var roleClaims = _httpContextAccessor.HttpContext.User.ClaimsRoles();

                foreach (var role in _roles)
                    if (roleClaims.Contains(role)) return;

                throw new Exception("You are Unauthorized for this request");
            }
        }
    }
}

