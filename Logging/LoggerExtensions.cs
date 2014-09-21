using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algomizer.Common.Logging
{
    public static class LoggerExtensions
    {
        public static void Debug(this ILogger logger, Func<string> getMessage)
        {
            if (logger.IsDebugEnabled)
            {
                logger.Debug(getMessage());
            }
        }

        public static void Info(this ILogger logger, Func<string> getMessage)
        {
            if (logger.IsInfoEnabled)
            {
                logger.Info(getMessage());
            }
        }

        public static void Warn(this ILogger logger, Func<string> getMessage)
        {
            if (logger.IsWarnEnabled)
            {
                logger.Warn(getMessage());
            }
        }

        public static void Error(this ILogger logger, Func<string> getMessage)
        {
            if (logger.IsErrorEnabled)
            {
                logger.Error(getMessage());
            }
        }

        public static void Fatal(this ILogger logger, Func<string> getMessage)
        {
            if (logger.IsFatalEnabled)
            {
                logger.Fatal(getMessage());
            }
        }
    }
}
