using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngine.Orders
{
    public enum RejectionReason
    {
        Unknown,
        OrderNotFound,
        InstrumentNotFound,
        AttemptingToModifyWrongSide,
    }
}
