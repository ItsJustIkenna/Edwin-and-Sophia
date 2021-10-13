using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingEngine.Core.Configuration;
using TradingEngine.Logging;
using TradingEngine.Logging.LoggingConfiguration;

namespace TradingEngine.Core
{
    public sealed class TradingEngineHostBuilder
    {
        public static IHost BuildTradingEngine()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Start with configuration
                services.AddOptions();
                services.Configure<EdwinServerConfiguration>(context.Configuration.GetSection(nameof(EdwinServerConfiguration)));
                services.Configure<LoggerConfiguration>(context.Configuration.GetSection(nameof(LoggerConfiguration)));


                // Add singleton objects
                services.AddSingleton<IEdwinServer, EdwinServer>();
                services.AddSingleton<ITextLogger, TextLogger>();

                // Add hosted service
                services.AddHostedService<EdwinServer>();
            }).Build();
    }
}
