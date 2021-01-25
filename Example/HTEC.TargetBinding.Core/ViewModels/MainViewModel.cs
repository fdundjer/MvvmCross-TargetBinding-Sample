using System;
using System.Drawing;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace HTEC.TargetBinding.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private static readonly Random Rand = new Random();
        private Color _imageTintColor;

        public MainViewModel()
        {
            ChangeTintColorCommand = new MvxCommand(HandleChangeTintColorCommand);
        }

        public MvxCommand ChangeTintColorCommand { get; set; }

        public Color ImageTintColor
        {
            get => _imageTintColor;
            set => SetProperty(ref _imageTintColor, value);
        }

        private void HandleChangeTintColorCommand()
        {
            ImageTintColor = Color.FromArgb(Rand.Next(256), Rand.Next(256), Rand.Next(256));
        }
    }
}
