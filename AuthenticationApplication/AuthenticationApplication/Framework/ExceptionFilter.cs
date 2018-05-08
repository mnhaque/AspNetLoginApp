namespace AuthenticationApplication.Framework
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Filters;
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
