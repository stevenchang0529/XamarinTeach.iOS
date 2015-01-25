using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using System.Linq;
namespace L04_Navigation
{
	partial class FinalViewController : UIViewController
	{

        public string Value { get; set; }
		public FinalViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.MyLabel.Text = Value;
        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.NavigationController.PopViewControllerAnimated(true);
        }

        partial void UIButton96_TouchUpInside(UIButton sender)
        {
            this.NavigationController.PopToRootViewController(true);
        }

        partial void UIButton99_TouchUpInside(UIButton sender)
        {
            
                 

                 this.NavigationController.PopToViewController(this.NavigationController.ViewControllers.Single(c=>c is L04NavigationViewController), true);
        }
	}
}
