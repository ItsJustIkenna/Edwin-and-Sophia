using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngine.Orders
{
    public sealed class RejectCreator
    {
        public static Rejection GenerateOrderCoreRejection(IOrderCore rejectedOrder, RejectionReason rejectionReason)
        {
            return new Rejection(rejectedOrder, rejectionReason);
        }
    }
}
