using Execom.TargetBinding.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace Execom.TargetBinding.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public MainView()
            : base(nameof(MainView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Apply();
        }
    }
}