using System;
using System.Collections.Generic;
using System.Text;
using TradingEngine.Orders;

namespace TradingEngine.Orderbook
{
    interface IRetrievalOrderbook : IOrderEntryOrderbook
    {
        List<OrderbookEntry> GetAskOrders();
        List<OrderbookEntry> GetBidOrders();
    }
}
