using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB.Controllers
{
    public class LogMessage
    {
        public int ThreadId { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
