using System;
namespace Core.Utilities.Result.Abstract
{
    public interface IDataResult<T> : IResponse
    {
        T Data { get; set; }
    }
}

