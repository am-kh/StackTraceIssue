using System.Diagnostics;
using CrashiOS;
using Serilog;

Log.Logger = new LoggerConfiguration()
        .WriteTo.Console()
        .WriteTo.Debug()
        .MinimumLevel.Information()
        .CreateLogger();

AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
UIApplication.Main (args, null, typeof (AppDelegate));


void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
{
    var ex = (Exception)e.ExceptionObject;
    Log.Fatal(ex,ex.Message);
    Debugger.Break();
}