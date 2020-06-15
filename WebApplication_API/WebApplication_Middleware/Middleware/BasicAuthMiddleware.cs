using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApplication_Middleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public BasicAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string authHeader = httpContext.Request.Headers["Authorization"];
            Debug.WriteLine("Basic Auth : "+ authHeader);

            if (authHeader != null)
            {
                var auth = authHeader.Split(new char[] { ' ' })[1];

                Encoding encoding = Encoding.GetEncoding("UTF-8");
                var usernameAndPassword  =  encoding.GetString(Convert.FromBase64String(auth));
                Debug.WriteLine("username And Pass : " + usernameAndPassword);
                string username = usernameAndPassword.Split(new char[] { ':' })[0];
                string password = usernameAndPassword.Split(new char[] { ':' })[1];
                if (username.Equals("acc1") && password.Equals("123"))
                {
                    await _next(httpContext);
                }
                
            }
            else
            {
                httpContext.Response.StatusCode = 401;
                return;
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class BasicAuthMiddlewareExtensions
    {
        public static IApplicationBuilder UseBasicAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BasicAuthMiddleware>();
        }
    }
}
