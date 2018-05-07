using AuthenticationApplication.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationApplication.Filteres
{
    public class ExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            HttpResponse response = context.HttpContext.Response;
            if (exception.GetType() == typeof(DuplicatePrimaryKeyException))
            {
                context.ExceptionHandled = true;
                response.StatusCode = 400;
                response.WriteAsync(exception.Message);
            }
        }
    }
}
