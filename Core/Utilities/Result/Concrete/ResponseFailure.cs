using System;
namespace Core.Utilities.Result.Concrete
{
    public class ResponseFailure : Response
    {
        public ResponseFailure(bool status) : base(status)
        {
        }

        public ResponseFailure(string statusText) : base(status:false, statusText)
        {
        }
    }
}

