namespace Ustilz.AspNetCore
{
    using System;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;

    internal class LoggingServerAddressesStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
            => builder =>
            {
                builder.UseMiddleware<LoggingServerAddressesMiddleware>();
                /* builder.UseEndpoints(endpoints => {
                     endpoints.MapControllers();
                 });*/
                next(builder);
            };
    }
}
