using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;

namespace Algomizer.Common.Logging
{
    public static class GenericLoggingExtensions
    {
        public static ILogger Logger(this object obj, string name)
        {
            return LogManager.GetLogger(name);
        }
    }
}
