using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace L06_WebAPI
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.btnJson.TouchUpInside +=async  (sender, e) =>
            {
           // L06_WebAPI.Share.APIService service = new Share.APIService();
                L06_WebAPI.Service.APIServicePCL service = new Service.APIServicePCL();
            var data=await service.GetJson();
            this.lblName.Text = data.Name;
            this.lblAge.Text = data.Age.ToString();
            this.lblWork.Text = data.Work;
        
            };
            // Perform any additional setup after loading the view, typically from a nib.
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