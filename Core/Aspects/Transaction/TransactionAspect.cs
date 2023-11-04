using System;
using System.Transactions;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Core.Aspects.Transaction
{
    public class TransactionAspect : MethodInterception //Hazırladığımız MethodInterception aspect oluşturup işlem yapmamızı sağlıyor
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transaction = new TransactionScope())//Scope kullanalım asp net ile gelen transaction yapısı
            {
                try
                {
                    invocation.Proceed();//hata yoksa proceed yaparak devam et ve
                    transaction.Complete();//transactionu bitir

                }
                catch (Exception ex)
                {
                    transaction.Dispose();//eğer bir hata olursa yaptığım tüm işlemleri geri al
                    throw;
                }
            }
        }
    }
}

