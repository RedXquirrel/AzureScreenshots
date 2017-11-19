using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Core.ViewModels;
using MvvmCross.Mac.Views;
using Azure.Screenshots.Core.ViewModels;


namespace Azure.ScreenShots.Mac.Views
{
    [MvxViewFor(typeof(SecondViewModel))]
    public partial class SecondViewController : MvxViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public SecondViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public SecondViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public SecondViewController() : base("SecondView", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed view accessor
        public new SecondView View
        {
            get
            {
                return (SecondView)base.View;
            }
        }
    }
}
