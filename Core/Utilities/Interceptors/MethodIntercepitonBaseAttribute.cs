using System;
using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodIntercepitonBaseAttribute : Attribute, Castle.DynamicProxy.IInterceptor//abstract çevirelim ki override edebilelim sonra
    {
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}

