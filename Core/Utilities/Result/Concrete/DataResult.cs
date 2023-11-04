using System;
using Core.Utilities.Result.Abstract;

namespace Core.Utilities.Result.Concrete
{
    public class DataResult<T> : Response, IDataResult<T>
    {
        public DataResult(T data, bool status) : base(status)
        {
            Data = data;
        }

        public DataResult(T data, bool status, string statusText) : base(status, statusText)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}

