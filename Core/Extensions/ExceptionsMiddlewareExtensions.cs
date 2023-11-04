using System;
using Microsoft.AspNetCore.Builder;

namespace Core.Extensions
{
    public static class ExceptionsMiddlewareExtensions
    {
     public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();//bunu da gidip program cs çağıralım
        } 
    }
}

