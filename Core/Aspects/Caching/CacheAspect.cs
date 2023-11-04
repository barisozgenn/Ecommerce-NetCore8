using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Caching
{
    public class CacheAspect: MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}." +
                $"{invocation.Method.Name}");//methodu ismiyle yakalayalım User.GetList gibi
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(p => p?.ToString() ?? "<Null>"))})";//method adı null olabilir diye p?

            if (_cacheManager.IsAdded(key:key))
            {
                invocation.ReturnValue = _cacheManager.Get(key: key);
                return;
            }
            invocation.Proceed();
            _cacheManager.Add(key: key, data: invocation.ReturnValue, _duration);
        }


    }
}

