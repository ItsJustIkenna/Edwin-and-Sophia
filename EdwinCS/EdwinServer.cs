using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using System;
using System.Threading;
using System.Threading.Tasks;

using TradingEngine.Core.Configuration;
using TradingEngine.Logging;

namespace TradingEngine.Core
{
    class EdwinServer : BackgroundService, IEdwinServer
    {
        private readonly EdwinServerConfiguration _edwinConfiguration;
        private readonly ITextLogger _logger;
        public EdwinServer(IOptions<EdwinServerConfiguration> edwinConfiguration, ITextLogger textLogger)
        {
            _edwinConfiguration = edwinConfiguration.Value ?? throw new ArgumentNullException(nameof(edwinConfiguration));
            _logger = textLogger ?? throw new ArgumentNullException(nameof(textLogger));
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.Information(nameof(EdwinServer), "Starting Trading Engine");
            while (!stoppingToken.IsCancellationRequested)
            { }
            _logger.Information(nameof(EdwinServer), "Stopping Trading Engine");
            return Task.CompletedTask;
        }
    }
}
