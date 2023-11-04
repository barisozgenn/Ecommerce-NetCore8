using System;
namespace Core.Utilities.Result.Concrete
{
    public class DataResultFailure<T> : DataResult<T>
    {
        public DataResultFailure(T data) : base(data, status: false)
        {
        }

        public DataResultFailure(T data, string statusText) : base(data, status: false,  statusText)
        {
        }

        public DataResultFailure(string statusText) : base(data: default, status: false,  statusText)
        {
        }
    }
}

