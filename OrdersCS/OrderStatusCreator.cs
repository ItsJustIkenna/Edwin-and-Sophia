using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngine.Orders
{
    public sealed class OrderStatusCreator
    {
        public static NewOrderStatus GenerateNewOrderStatus(Order order)
        {
            return new NewOrderStatus();
        }

        public static ModifyOrderStatus GenerateModifyOrderStatus(ModifyOrder modifyOrder)
        {
            return new ModifyOrderStatus();
        }

        public static CancelOrderStatus GenerateCancelOrderStatus(CancelOrder cancelOrder)
        {
            return new CancelOrderStatus();
        }
    }
}
