using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareFile.Api.Client.Logging
{
    public class LogEventArgs : EventArgs
    {
        public String message { get; set; }
        public LogType logType { get; set; }
    }
}
