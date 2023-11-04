using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector //Class attbutes ile methodların veya classların başında yazdığım tagları yakalayalım ve sıraya koymak için hazırlayalım
    {
        public Castle.DynamicProxy.IInterceptor[] SelectInterceptors(Type type, MethodInfo method, Castle.DynamicProxy.IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodIntercepitonBaseAttribute>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodIntercepitonBaseAttribute>(true);

            classAttributes.AddRange(methodAttributes);

            return (Castle.DynamicProxy.IInterceptor[])classAttributes.ToArray();
        }
    }
}

