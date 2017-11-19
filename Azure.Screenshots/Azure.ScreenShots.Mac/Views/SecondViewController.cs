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
    [MvxViewFor(typeof(SecondViewModel))]
    public partial class SecondViewController : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new NSView(new CGRect(0, 0, 320, 400));
            base.ViewDidLoad();

            var textEditFirst = new NSTextField(new CGRect(0, 0, 320, 40));
            View.AddSubview(textEditFirst);
            var textEditSecond = new NSTextField(new CGRect(0, 50, 320, 40));
            View.AddSubview(textEditSecond);
            var slider = new NSSlider(new CGRect(0, 150, 320, 40));
            slider.MinValue = 0;
            slider.MaxValue = 100;
            slider.IntValue = 23;
            View.AddSubview(slider);
            var labelFull = new NSTextField(new CGRect(0, 100, 320, 40));
            labelFull.Editable = false;
            labelFull.Bordered = false;
            labelFull.AllowsEditingTextAttributes = false;
            labelFull.DrawsBackground = false;
            View.AddSubview(labelFull);
            var sw = new NSButton(new CGRect(0, 200, 320, 40));
            sw.SetButtonType(NSButtonType.Switch);
            View.AddSubview(sw);
            //sw.AddObserver()

            var set = this.CreateBindingSet<SecondViewController, SecondViewModel>();
            //set.Bind(textEditFirst).For(v => v.StringValue).To(vm => vm.FirstName);
            //set.Bind(textEditSecond).For(v => v.StringValue).To(vm => vm.LastName);
            set.Bind(labelFull).Described("SliderValue + ' ' + OnOffValue").For("StringValue");
            //set.Bind(slider).For("IntValue").To(vm => vm.SliderValue);
            //set.Bind(sw).For(c => c.State).To(vm => vm.OnOffValue);


            set.Apply();
        }
    }
}
