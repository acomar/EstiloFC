using log4net;
using System;

namespace Infrastructure.Log
{
    public class LogHelper : Infrastructure.Log.ILogHelper
    {
        protected static ILog log;

        public LogHelper()
        {
            log = GetLogger();
        }

        private ILog GetLogger()
        {
            return LogManager.GetLogger(GetType());
        }

        public void Error(string message)
        {
            log.Error(message);
        }

        public void Error(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }
}
