using System;
using HTEC.TargetBinding.Core.ViewModels;
using HTEC.TargetBinding.iOS.Converters;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace HTEC.TargetBinding.iOS.Views
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
            LogoImageView.Image = LogoImageView.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);

            base.ViewDidLoad();
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(ChangeTintColorButton).To(vm => vm.ChangeTintColorCommand);
            set.Bind(LogoImageView).For(v => v.TintColor).To(vm => vm.ImageTintColor).TwoWay().WithConversion(new TwoWayNativeColorValueConverter());
            set.Apply();

            ChangeTintColorButton.TouchUpInside += (sender, args) =>
            {
                if (LogoImageView.Image.RenderingMode != UIImageRenderingMode.AlwaysTemplate)
                {
                    LogoImageView.Image = LogoImageView.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
                }
                
                if (ViewModel.ChangeTintColorCommand.CanExecute())
                {
                    ViewModel.ChangeTintColorCommand.Execute();
                }
            };

            ResetColorToDefaultButton.TouchUpInside += (sender, args) =>
            {
                if (LogoImageView.Image.RenderingMode != UIImageRenderingMode.AlwaysOriginal)
                {
                    LogoImageView.Image = LogoImageView.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
                }
            };
        }
    }
}