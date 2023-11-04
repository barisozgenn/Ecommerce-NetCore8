using System;
using System.Net;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);//eğer işlem devam ederken hata almadıysa httpcontext i gönder
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.ContentType ="application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = "Internal Server Error Barbar";

            IEnumerable<ValidationFailure> errors;

            if (ex.GetType() == typeof(ValidationException))//validation hatası varsa buna girip fluent sayesinde hatayı gösterecek
            {
                message = ex.Message;
                errors = ((ValidationException)ex).Errors;

                return httpContext.Response.WriteAsync(new ValidationErrorDetails
                {
                    Errors = errors,
                    Message = message,
                    StatusCode = 400
                }.ToString());
            }

            return httpContext.Response.WriteAsync(new ErrorHandlerDetails
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = ex.Message
            }.ToString()); 
        }
    }
}

