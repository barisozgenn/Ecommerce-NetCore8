using System;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodIntercepitonBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation)//işlem öncesi burayı çağıralım
        { }
        protected virtual void OnAfter(IInvocation invocation)//işlem sonrası burayı çağıralım
        { }
        protected virtual void OnException(IInvocation invocation, Exception ex)//işlemde hata olduğun burayı çağıralım
        { }
        protected virtual void OnSuccess(IInvocation invocation)//işlem başarıyla tamamlandığında burayı çağıralım
        { }

        public override void Intercept(IInvocation invocation)//invocation ile method içinde ne kadar veri varsa taşıyalım
        {
            var isSuccess = true;

            OnBefore(invocation: invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                OnException(invocation: invocation, ex: ex);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation: invocation);
                }
            }

            OnAfter(invocation: invocation);
        }
    }
}

