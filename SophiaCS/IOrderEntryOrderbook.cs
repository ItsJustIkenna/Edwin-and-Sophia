using System;
using System.Collections.Generic;
using System.Text;
using TradingEngine.Orders;

namespace TradingEngine.Orderbook
{
    public interface IOrderEntryOrderbook : IReadOnlyOrderbook
    {
        void AddOrder(Order order);
        void ChangeOrder(ModifyOrder modifyOrder);
        void RemoveOrder(CancelOrder modifyOrder);
    }
}
