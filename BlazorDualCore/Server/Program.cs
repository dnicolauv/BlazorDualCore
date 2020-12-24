using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BlazorDualCore.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseSetting(WebHostDefaults.DetailedErrorsKey, "true");//TODO: remove on prod
                });
    }

        //    public static void Main(string[] args)
        //    {
        //        BuildWebHost(args).Run();
        //    }

        //    public static IWebHost BuildWebHost(string[] args) =>
        //        WebHost.CreateDefaultBuilder(args)
        //            .UseConfiguration(new ConfigurationBuilder()
        //                .AddCommandLine(args)
        //                .Build())
        //            .UseStartup<Startup>()
        //            .Build();
        //}
    }
