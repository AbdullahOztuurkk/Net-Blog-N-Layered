using System.Reflection;
using System.Runtime.InteropServices;
using BlogWebUI.Business.Aspects.LogAspects;
using BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("BlogWebUI.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("BlogWebUI.Business")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(FileLogger),AttributeTargetTypes ="BlogWebUI.Business.Concrete")]
[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "BlogWebUI.Business.Concrete")]


// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("20929241-6d0e-4183-b5c3-a46ba2c0717c")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
