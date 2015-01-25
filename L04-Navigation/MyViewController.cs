using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace L04_Navigation
{
	partial class MyViewController : UIViewController
	{

        public string Iam18YearsOld { get; set; }
        
		public MyViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            lblTest.Text = this.Iam18YearsOld;
        }

        partial void UIButton64_TouchUpInside(UIButton sender)
        {

            var controller = UIStoryboard.FromName("MainStoryboard", null).InstantiateViewController("FinalViewController") as FinalViewController;
            controller.Value = this.txtValue.Text;
            this.NavigationController.PushViewController(controller, true);
        }
	}
}
