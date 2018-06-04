using Execom.TargetBinding.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;

namespace Execom.TargetBinding.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}


