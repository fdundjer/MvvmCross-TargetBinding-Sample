using HTEC.TargetBinding.Core.ViewModels;
using MvvmCross.ViewModels;

namespace HTEC.TargetBinding.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart<MainViewModel>();
        }
    }
}
