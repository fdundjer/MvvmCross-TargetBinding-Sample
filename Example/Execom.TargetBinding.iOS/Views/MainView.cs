using System;
using Execom.TargetBinding.Core.ViewModels;
using Execom.TargetBinding.iOS.Converters;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Execom.TargetBinding.iOS.Views
{
    [MvxRootPresentation]
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView()
            : base(nameof(MainView), null)
        {
        }

        public override void ViewDidLoad()
        {
            LogoImageView.Image = LogoImageView.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);

            base.ViewDidLoad();
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(ChangeTintColorButton).To(vm => vm.ChangeTintColorCommand);
            set.Bind(LogoImageView).For(v => v.TintColor).To(vm => vm.ImageTintColor).TwoWay()
                .WithConversion(new TwoWayNativeColorValueConverter());
            set.Apply();

            ResetColorToDefaultButton.TouchUpInside += (sender, args) =>
            {
                LogoImageView.TintColor = new UIColor((nfloat) (234 / 255.0), (nfloat) (78 / 255.0),
                    (nfloat) (81 / 255.0), (nfloat) (255 / 255.0));
            };
        }
    }
}