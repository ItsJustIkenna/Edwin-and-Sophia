using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingEngine.Core.Configuration;

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

                // Add singleton objects
                services.AddSingleton<IEdwinServer, EdwinServer>();

                // Add hosted service
                services.AddHostedService<EdwinServer>();
            }).Build();
    }
}
