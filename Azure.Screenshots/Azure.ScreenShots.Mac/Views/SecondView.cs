﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace Azure.ScreenShots.Mac.Views
{
    public partial class SecondView : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public SecondView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public SecondView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
