using System;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResponse Run(params IResponse[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Status) return logic;
            }
            return new Response(status: true);
        }
    }
}

