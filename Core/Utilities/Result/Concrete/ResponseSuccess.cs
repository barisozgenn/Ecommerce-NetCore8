using System;
namespace Core.Utilities.Result.Concrete
{
    public class ResponseSuccess : Response
    {
        public ResponseSuccess(bool status) : base(status)
        {
        }

        public ResponseSuccess(string statusText) : base(status:true, statusText)
        {
        }
    }
}

