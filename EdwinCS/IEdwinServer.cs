using System.Threading;
using System.Threading.Tasks;

namespace TradingEngine.Core
{
    interface IEdwinServer
    {
        Task Run(CancellationToken token);
    }
}
