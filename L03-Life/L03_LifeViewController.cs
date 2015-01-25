using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace L03_Life
{
    public partial class L03LifeViewController : UIViewController
    {
        public L03LifeViewController(IntPtr handle)
            : base(handle)
        {
        }

       
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        //載入View完成，在此可以開始對控制項進行操作。
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("ViewDidLoad");
            var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
            this.Test(app.Value);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        //View即將出現在銀幕上
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            Console.WriteLine("ViewWillAppear");
        }

        //View在銀幕上呈現完成
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            Console.WriteLine("ViewDidAppear");
        }

        //目前的View將從銀幕上被移除
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            Console.WriteLine("ViewWillDisappear");
        }

        //View已移除，銀幕上已看不到
        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            Console.WriteLine("ViewDidDisappear");
        }

        #endregion

        public void Test(string value)
        {
            lbl.Text = value;
        }
    }


}