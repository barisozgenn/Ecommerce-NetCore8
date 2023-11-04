using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Caching
{
    public class CacheAspectRemove : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheAspectRemove(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }
        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(pattern: _pattern);//ekleme update flaan yaparsak ve cache kalmasın istiyorsak bunu çalıştırırız
        }
    }
}

