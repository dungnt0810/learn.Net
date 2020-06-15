using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApplication_Middleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LogIpMiddleware
    {
        private readonly RequestDelegate _next;

        public LogIpMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var ip = httpContext.Connection.RemoteIpAddress.ToString();
            var url = httpContext.Request.Path;
            Debug.WriteLine("ip : " + ip);
            Debug.WriteLine("url : " + url);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LogIpMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogIpMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogIpMiddleware>();
        }
    }
}
