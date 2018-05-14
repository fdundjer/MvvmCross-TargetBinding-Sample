using System;
using MvvmCross.Commands;
using MvvmCross.UI;
using MvvmCross.ViewModels;

namespace Execom.TargetBinding.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private static readonly Random Rand = new Random();
        private MvxColor _imageTintColor;

        public MainViewModel()
        {
            ChangeTintColorCommand = new MvxCommand(HandleChangeTintColorCommand);
        }

        public MvxCommand ChangeTintColorCommand { get; set; }

        public MvxColor ImageTintColor
        {
            get => _imageTintColor;
            set => SetProperty(ref _imageTintColor, value);
        }

        private void HandleChangeTintColorCommand()
        {
            ImageTintColor = new MvxColor(Rand.Next(256), Rand.Next(256), Rand.Next(256));
        }
    }
}
