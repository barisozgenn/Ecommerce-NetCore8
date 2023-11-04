using System;
namespace Core.Utilities.Result.Abstract
{
    public interface IResponse
    {
        public bool Status { get; }
        public string StatusText { get; set; }
    }
}

