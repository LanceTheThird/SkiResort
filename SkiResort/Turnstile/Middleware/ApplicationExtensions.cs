using Microsoft.AspNetCore.Builder;

namespace Turnstile.Middleware
{
    public static class ApplicationExtensions
   {
        public static IApplicationBuilder UseHandling(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandlingMiddleware>();
        }
    }
}
