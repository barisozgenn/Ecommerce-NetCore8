using System;
using System.Diagnostics;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Performance
{
    public class PerformanceAspect: MethodInterception
    {
        private int _interval;//kaç saniye sonra durduracağımızı söyleyelim
        private Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

       
        public PerformanceAspect()
        {
            _interval = 3; //eğer parametresiz çağırsıysak 3 saniye sonra dursun
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }
        protected override void OnAfter(IInvocation invocation)
        {
            _stopwatch.Stop();

            double seconds = _stopwatch.Elapsed.TotalSeconds;
            if (seconds > _interval)
            {
                //Mail attırırız
                //BD ye yazamayız constroctor bir parametre ister dolayısıyla db servislerini buraya gönderemeyiz
                //Peki ne yapabiliriz bağımlılık yapıp veya solidi ezip burada bir şekilde EfPerformanceDal = new EfPerformanceDal().Add().. deyip gönderebiliriz.
                Debug.WriteLine($"Performance Raporu: {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name} ==> {seconds}");//hangi method ta sıkıntı varsa görürüz
            }
            _stopwatch.Reset();
        }
    }
}

