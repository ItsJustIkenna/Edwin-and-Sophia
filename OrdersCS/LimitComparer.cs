using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TradingEngine.Orders
{
    public class BidLimitComparer : IComparer<Limit>
    {
        public static IComparer<Limit> Comparer { get; } = new BidLimitComparer();
        public int Compare(Limit x, Limit y)
        {
            if (x.Price == y.Price)
                return 0;
            else if (x.Price > y.Price)
                return -1;
            else return 1;
        }
    }

    public class AskLimitComparer : IComparer<Limit>
    {
        public static IComparer<Limit> Comparer { get; } = new AskLimitComparer();
        public int Compare(Limit x, Limit y)
        {
            if (x.Price == y.Price)
                return 0;
            else if (x.Price > y.Price)
                return 1;
            else return -1;
        }
    }
}
