using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDualCore.Client
{
    public class Program
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //Configure wasm client loader
            services.AddScoped<ClientLoader>();
            services.AddScoped<IClientLoaderConfiguration, ClientLoaderConfiguration>();

            services.AddScoped<BlazorDualCore.Shared.Data.WeatherForecastService>();

            services.AddScoped<BlazorDualCore.Shared.Data.LocationService>();
            services.AddScoped<BlazorDualCore.Shared.Data.EmployeeService>();
            services.AddScoped<BlazorDualCore.Shared.Data.EmployerService>();
            services.AddScoped<BlazorDualCore.Shared.Data.JobService>();
        }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // Supply HttpClient instances that include access tokens when making requests to the server project            
            builder.Services.AddHttpClient("BlazorDualCore.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            builder.Services.AddHttpClient("BlazorDualCore.API", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorDualCore.ServerAPI"));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorDualCore.API"));
            ConfigureServices(builder.Services);

            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}
