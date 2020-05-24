using log4net;

namespace BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger() : base(LogManager.GetLogger("DatabaseLogger"))
        {
            //Configürasyon dosyasına yazacağımız DatabaseLogger connection string'ini alacak.  
        }
    }
}
