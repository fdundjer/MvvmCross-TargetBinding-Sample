using Execom.TargetBinding.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Execom.TargetBinding.Core
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
