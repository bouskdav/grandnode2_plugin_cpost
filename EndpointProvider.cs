using Grand.Infrastructure.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Shipping.CPost
{
    public partial class EndpointProvider : IEndpointProvider
    {
        public void RegisterEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute("Plugins.CPost.Points",
                 "Plugins/CPost/Points",
                 new { controller = "CPostShipping", action = "Points" }
            );
        }

        public int Priority => 0;
    }
}
