using System;
using System.Diagnostics;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolver
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();//cachlemeyi ekledik program cs e dahil edelim ServiceCollectionExtensions aracılığı ile
            services.AddSingleton<ICacheManager, MemoryCacheManager>();//yarın öbür gün cache sistemindeki yapıyı değiştirirsek burayı değiştirmemiz yeterli oalcak
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//user framelere artık ulaşabiliriz
            services.AddSingleton<Stopwatch>();//bir işlem beklenenden daha uzun sürerse bize bildirsin süreyi belirleyelim aspect te
        }
    }
}

