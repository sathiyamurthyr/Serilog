using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DB.Controllers
{
    public interface ILoggerService
    {
        void Log(LogLevel logLevel, string message);
    }
}
