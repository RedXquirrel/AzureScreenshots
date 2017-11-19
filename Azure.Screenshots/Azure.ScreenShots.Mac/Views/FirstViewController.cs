using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Mac.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using Azure.Screenshots.Core.ViewModels;
using CoreGraphics;

namespace Azure.ScreenShots.Mac.Views
{
    [MvxViewFor(typeof(FirstViewModel))]
    public partial class FirstViewController : MvxViewController
    {
        #region Constructors
        // Called when created from unmanaged code
        public FirstViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }
        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public FirstViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }
        // Call to load from the XIB/NIB file
        public FirstViewController() : base()
        {
            Initialize();
        }
        // Shared initialization code
        void Initialize()
        {
        }
        #endregion

        public override void ViewDidLoad()
        {
            View = new NSView(new CGRect(0, 100, 320, 400));
            base.ViewDidLoad();

            var textEditFirst = new NSTextField(new CGRect(10, 0, 320, 40));
            View.AddSubview(textEditFirst);
            var textEditSecond = new NSTextField(new CGRect(10, 50, 320, 40));
            View.AddSubview(textEditSecond);
            var labelFull = new NSTextField(new CGRect(10, 100, 320, 40));
            View.AddSubview(labelFull);
            var bu = new NSButton(new CGRect(0, 150, 320, 40));
            bu.Title = "Hello";
            View.AddSubview(bu);


            var set = this.CreateBindingSet<FirstViewController, FirstViewModel>();
            set.Bind(textEditFirst).For(v => v.StringValue).To(vm => vm.Hello);
            set.Bind(textEditSecond).For(v => v.StringValue).To(vm => vm.LastName);
            set.Bind(labelFull).For(v => v.StringValue).To(vm => vm.FullName);
            set.Bind(bu).For("Activated").To("GoCommand");
            set.Apply();

        }
    }
}
