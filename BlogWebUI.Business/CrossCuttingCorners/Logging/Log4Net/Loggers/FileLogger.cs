using log4net;

namespace BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net.Loggers
{
    public class FileLogger:LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
            //Belirtiğimiz yola JSON formatında log alacak.
        }
    }
}
