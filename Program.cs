using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace SerilogAndSeqDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            log.Information("Hello Nitai, from Serilog!");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
