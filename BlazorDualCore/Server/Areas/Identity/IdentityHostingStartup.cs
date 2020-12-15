using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BlazorDualCore.Areas.Identity.IdentityHostingStartup))]
namespace BlazorDualCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}