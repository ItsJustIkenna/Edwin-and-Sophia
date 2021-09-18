using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using System;
using System.Threading;
using System.Threading.Tasks;

using TradingEngine.Core.Configuration;

namespace TradingEngine.Core
{
    class EdwinServer : BackgroundService, IEdwinServer
    {
        private readonly EdwinServerConfiguration _edwinConfiguration;
        public EdwinServer(IOptions<EdwinServerConfiguration> edwinConfiguration)
        {
            _edwinConfiguration = edwinConfiguration.Value ?? throw new ArgumentNullException(nameof(edwinConfiguration));
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            { }
            return Task.CompletedTask;
        }
    }
}
