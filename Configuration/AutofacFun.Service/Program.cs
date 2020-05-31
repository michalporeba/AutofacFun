using System.IO;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AutofacFun.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ASP.NET Core 3.0+:
            // The UseServiceProviderFactory call attaches the
            // Autofac provider to the generic hosting mechanism.
            var host = Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        //.UseIISIntegration()
                        .ConfigureLogging((hostingContext, builder) =>
                        {
                            builder
                                .ClearProviders()
                                .SetMinimumLevel(LogLevel.Trace)
                                .AddConfiguration(hostingContext.Configuration.GetSection("Logging"))
                                .AddConsole()
                                .AddDebug();
                        })
                        .UseStartup<Startup>();
                }).Build();

            host.Run();
        }
    }
}
