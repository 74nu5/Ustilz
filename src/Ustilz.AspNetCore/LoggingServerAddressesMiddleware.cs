namespace Ustilz.AspNetCore
{
    #region Usings

    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Hosting.Server;
    using Microsoft.AspNetCore.Hosting.Server.Features;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Features;

    #endregion

    internal class LoggingServerAddressesMiddleware
    {
        private readonly IFeatureCollection features;

        public LoggingServerAddressesMiddleware(IServer server)
            => this.features = server.Features;

        public async Task Invoke(HttpContext context)
        {
            // fetch the addresses
            var addressFeature = this.features.Get<IServerAddressesFeature>();
            var addresses = addressFeature.Addresses;

            // Write the addresses as a comma separated list
            await context.Response.WriteAsync(string.Join(",", addresses));
        }
    }
}
