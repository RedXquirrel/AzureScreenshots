using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using MvvmCross.Mac.Views;
using Azure.Screenshots.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Bindings;

namespace Azure.Screenshots.Mac.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView",null)
        {
            
        }

        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();



            var set = this.CreateBindingSet<FirstView, FirstViewModel>();

            var VM = (FirstViewModel)this.BindingContext;

            var a = VM.Hello;


            /*
            set.Bind();
            set.Bind<NSTextField>(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);

            set.Bind<NSTextField>(Label)
            .For("StringValue")
            .To(vm => vm.Greeting);
                    set.Bind(HelloLabel)
                        .For(c => c.StringValue)
                        .To(vm => vm.Greeting)
                        .OneWay();
                    set.Apply();

            set.Apply();
            */
        }
    }
}
