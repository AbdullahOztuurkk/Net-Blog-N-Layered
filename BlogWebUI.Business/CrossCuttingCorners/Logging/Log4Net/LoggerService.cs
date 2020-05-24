using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net
{
    [Serializable]
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsInfoEnabled => _log.IsInfoEnabled;

        public void Info(object Message)
        {
            if(IsInfoEnabled)
                _log.Info(Message);
        }
        public void Warn(object Message)
        {
            if (IsWarnEnabled)
                _log.Warn(Message);
        }
        public void Debug(object Message)
        {
            if (IsDebugEnabled)
                _log.Debug(Message);
        }
        public void Fatal(object Message)
        {
            if (IsFatalEnabled)
                _log.Fatal(Message);
        }
        public void Error(object Message)
        {
            if (IsErrorEnabled)
                _log.Error(Message);
        }
    }
}
