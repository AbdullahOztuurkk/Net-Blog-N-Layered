using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Business.CrossCuttingCorners.Logging;
using BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace BlogWebUI.Business.Aspects.LogAspects
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Instance)]
    //Constructor logu engellendi.
    public class LogAspect:OnMethodBoundaryAspect
    {
        public LogAspect(Type loggerType)
        {
            _LoggerType = loggerType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (_LoggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong Log Type !");
            }

            _LoggerService = (LoggerService)Activator.CreateInstance(_LoggerType);
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            if (!_LoggerService.IsInfoEnabled)
            {
                return;
            }
            else
            {
                var Parameters = args.Method.GetParameters().Select((t, i) => new LogParameter
                {
                    Name = t.Name,
                    Type = t.ParameterType.Name,
                    Value = args.Arguments.GetArgument(i)
                }).ToList();

                var LogDetails = new LogDetail
                {
                    FullName = args.Method.DeclaringType == null ? null :args.Method.DeclaringType.Name,
                    LogParameters = Parameters,
                    MethodName = args.Method.Name
                };

                _LoggerService.Info(LogDetails);
            }
            base.OnEntry(args);
        }

        public Type _LoggerType { get; set; }
        public LoggerService _LoggerService { get; set; }

    }
}
