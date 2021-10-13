using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngine.Logging
{
    public record LogInformation(LogLevel Loglevel, string Module, string Message, DateTime Now, int ThreadID, string ThreadName);
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}