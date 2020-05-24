using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebUI.Business.CrossCuttingCorners.Logging
{
    public class LogDetail
    {
        public string FullName { get; set; }//Namespace'i de kapsayan yol
        public string MethodName { get; set; }//Method adı
        public List<LogParameter> LogParameters { get; set; }
    }
}
