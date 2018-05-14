using Android.App;
using Android.OS;
using Execom.TargetBinding.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Execom.TargetBinding.Android.Views
{
    [Activity(Label = "Main activity")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}