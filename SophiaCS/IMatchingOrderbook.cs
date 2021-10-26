using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngine.Orderbook
{
    interface IMatchingOrderbook : IRetrievalOrderbook
    {
        MatchResult Match();
    }
}
