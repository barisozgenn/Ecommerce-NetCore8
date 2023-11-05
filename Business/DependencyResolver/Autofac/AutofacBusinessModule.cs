using System;
using Autofac;
using Business.Managers.Admin;
using Business.Services.Admin;
using Business.Utilities.Message;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Repositories.Admin;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module //Module classını Autofac ten çağırdık
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Tüm Dependency Injection lar burada yapılacak
            builder.RegisterType<AdminRoleManager>().As<IAdminRoleService>();
            builder.RegisterType<AdminRoleDal>().As<IAdminRoleDal>();

            builder.RegisterType<AdminUserManager>().As<IAdminUserService>();
            builder.RegisterType<AdminUserDal>().As<IAdminUserDal>();

            builder.RegisterType<AdminUserRoleManager>().As<IAdminUserRoleService>();
            builder.RegisterType<AdminUserRoleDal>().As<IAdminUserRoleDal>();

            builder.RegisterType<AdminEmailParameterManager>().As<IAdminEmailParameterService>();
            builder.RegisterType<AdminEmailParameterDal>().As<IAdminEmailParameterDal>();

            builder.RegisterType<AdminAuthManager>().As<IAdminAuthService>();

            builder.RegisterType<TokenHandler>().As<ITokenHandler>();

            builder.RegisterType<AdminMessageManager>().As<IAdminMessageService>();
            builder.RegisterType<UserMessageManager>().As<IUserMessageService>();
            builder.RegisterType<ProductMessageManager>().As<IProductMessageService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assemblies: assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(
                new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

