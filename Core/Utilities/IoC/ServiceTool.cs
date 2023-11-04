using System;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    //IoC nedir?
    //Uygulamayı tersine döndürmek olarakta geçer
    //Uygulamanın lifecycle boyunca birbirine bağımlılığını en aza indirecek nesneler oluşturmayı amaçlayan yazılım prensibi
    //Nesnelerin yaşam döngüsünden sorumlu yönetimi sağlar
    //IoC kullanan sınıfa bir interface inject edildiğinde ilgili interface methodları kullnabilir olur. 
    public static class ServiceTool
    {
        public static IServiceProvider? ServiceProvider { get; private set; } //program cs deki servislere ulaşıp bunu geri döndürelim
        public static IServiceCollection Create(IServiceCollection services)//bu programdaki services yapısı injecte edip kullanmayı sağlar
        {
            ServiceProvider = services.BuildServiceProvider();//methodu oluşturalım gönderdiğimiz collection service ten
            return services;
        }
    }
}

