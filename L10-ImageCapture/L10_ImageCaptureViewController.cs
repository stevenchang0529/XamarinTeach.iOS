using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Media;
using System.Threading.Tasks;

namespace L10_ImageCapture
{
    public partial class L10ImageCaptureViewController : UIViewController
    {
        public L10ImageCaptureViewController(IntPtr handle)
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

        partial void UIButton5_TouchUpInside(UIButton sender)
        {
            //MediaPicker  mediaPicker=new MediaPicker();
            //MediaPickerController media = mediaPicker.GetTakePhotoUI(new StoreCameraMediaOptions()
            //{
            //    Name = "test.jpg",
            //    Directory = "MediaPickerSample"
            //});
            //this.PresentViewController(media, true, null);
            //media.GetResultAsync().ContinueWith(t=>
            //{
            //    this.DismissViewController(true,null);
            //    var file = t.Result;
            //    MyImg.Image = UIImage.FromFile(file.Path);
            //}, TaskScheduler.FromCurrentSynchronizationContext());

            UIImagePickerController pick = new UIImagePickerController();
            pick.FinishedPickingMedia += (obj, e) =>
            {

                MyImg.Image = e.OriginalImage;
                pick.DismissViewController(true, null);

            };
            pick.SourceType = UIImagePickerControllerSourceType.Camera;
            this.PresentViewController(pick, true, null);
        }
    }
}