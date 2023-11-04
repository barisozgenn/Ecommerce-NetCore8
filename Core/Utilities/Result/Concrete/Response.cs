using System;
using Core.Utilities.Result.Abstract;

namespace Core.Utilities.Result.Concrete
{
    public class Response : IResponse
    {

        public Response(bool status)
        {
            Status = status;
        }

        public Response(bool status, string statusText): this(status)
        {
            StatusText = statusText;
        }

        public bool Status { get; set; }
        public string StatusText { get; set; }
    }
}

