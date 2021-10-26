using System;

namespace TradingEngine.Orderbook
{
    public interface IReadOnlyOrderbook
    {
        bool ContainsOrder(long orderId);
        OrderbookSpread GetSpread();
        int Count { get;  }
    }
}
