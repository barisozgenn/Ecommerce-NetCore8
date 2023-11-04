using System;
namespace Core.Utilities.Result.Concrete
{
    public class DataResultSuccess<T> : DataResult<T>
    {
        public DataResultSuccess(T data) : base(data, status: true)
        {
        }

        public DataResultSuccess(T data, string statusText) : base(data, status: true, statusText)
        {
        }

        public DataResultSuccess(string statusText) : base(data: default, status: true,  statusText)
        {
        }
    }
}

