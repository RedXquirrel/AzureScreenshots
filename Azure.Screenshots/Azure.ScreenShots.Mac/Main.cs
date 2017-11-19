using AppKit;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Azure.ScreenShots.Mac
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);
        }
    }
}
