using Android.App;
using Execom.TargetBinding.Core;
using MvvmCross.Platforms.Android.Views;

namespace Execom.TargetBinding.Android
{
    [Activity(Label = "Execom Target Binding", MainLauncher = true, Theme = "@style/Theme.Splash", Icon = "@mipmap/ic_launcher", NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity<Setup, App>
    {
        public SplashScreen()
            : base(Resource.Layout.activity_splash_screen)
        {
        }
    }
}