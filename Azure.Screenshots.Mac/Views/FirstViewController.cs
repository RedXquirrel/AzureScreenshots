using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Mac.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using Azure.Screenshots.Core.ViewModels;

namespace Azure.Screenshots.Mac.Views
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
        public FirstViewController() : base("FirstView", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            /*
            
            var set = this.CreateBindingSet<FirstViewController, FirstViewModel>();
            set.Bind(textEditFirst).For(v => v.StringValue).To(vm => vm.FirstName);
            set.Bind(textEditSecond).For(v => v.StringValue).To(vm => vm.LastName);
            set.Bind(labelFull).For(v => v.StringValue).To(vm => vm.FullName);
            set.Bind(bu).For("Activated").To("GoCommand");
            set.Apply();
            */
        }

        #endregion

        //strongly typed view accessor
        public new FirstView View
        {
            get
            {
                return (FirstView)base.View;
            }
        }
    }
}
