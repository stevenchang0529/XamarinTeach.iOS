﻿using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using L05_WebService.Service;

namespace L05_WebService.iOS
{
    public partial class L05WebServiceiOSViewController : UIViewController
    {
        public L05WebServiceiOSViewController(IntPtr handle)
            : base(handle)
        {
        }

        public  override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            MyService service = new MyService();
            MyButton.TouchUpInside +=async (sender, e) =>
            {
                MyButton.SetTitle(await service.GetData(999), UIControlState.Normal);
            };
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

     
    }
}