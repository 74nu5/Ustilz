namespace Ustilz.AspNetCore;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

[PublicAPI]
internal class LoggingServerAddressesMiddleware(IServer server)
{
    private readonly IFeatureCollection features = server.Features;

    public async Task Invoke(HttpContext context)
    {
        // fetch the addresses
        var addressFeature = this.features.GetRequiredFeature<IServerAddressesFeature>();
        var addresses = addressFeature.Addresses;

        // Write the addresses as a comma separated list
        await context.Response.WriteAsync(string.Join(",", addresses));
    }
}
