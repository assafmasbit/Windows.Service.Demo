using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Algomizer.Common.Logging
{
    public class LogManager : ILogManager
    {
        private static readonly ILogManager _logManager;

        static LogManager()
        {
            //var config = ConfigurationManager.AppSettings["Log4NetConfig"];
            //var fileInfo = new FileInfo(config);

            //log4net.Config.XmlConfigurator.Configure(fileInfo);
            //_logManager = new LogManager();
        }

        public static ILogger GetLogger(string name)
        {
            return _logManager.Get(name);
        }

        public ILogger Get(string name)
        {
            var logger = log4net.LogManager.GetLogger(name);
            return new LoggerAdapter(logger);
        }
    }
}
