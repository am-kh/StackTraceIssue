using Serilog;

namespace CrashiOS;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		Window = new UIWindow (UIScreen.MainScreen.Bounds);
		Window.RootViewController = new UINavigationController(new RootViewController());
		Window.MakeKeyAndVisible ();
		Log.Information("FinishedLaunching");
		return true;
	}
}

