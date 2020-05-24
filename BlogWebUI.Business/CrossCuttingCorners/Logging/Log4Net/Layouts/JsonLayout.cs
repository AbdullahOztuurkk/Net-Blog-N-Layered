using System;
using System.IO;
using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;

namespace BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net.Layouts
{
    public class JsonLayout:LayoutSkeleton
    {
        public override void ActivateOptions()
        {
            // throw new NotImplementedException();
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var log=new SerializableLogEvent(loggingEvent);
            //JSON için serializable bir event gereklidir.

            var _json = JsonConvert.SerializeObject(log, Formatting.Indented);
            //Gerekli formatlar verilerek json'a dönüştürüldü.

            writer.WriteLine(_json);
        }
    }
}
