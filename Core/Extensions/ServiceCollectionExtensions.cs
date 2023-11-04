using System;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
       public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(services: services);//oluşturduğumuz servisleri ekleyip dönelim
            }
            return ServiceTool.Create(services: services);//şimdi program cs de çağıralım
        }
    }
}

