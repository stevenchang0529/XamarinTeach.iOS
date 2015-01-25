using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;

namespace L02_Controls
{
    public partial class L02ControlsViewController : UIViewController
    {
        public L02ControlsViewController(IntPtr handle)
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

            this.btnClick.TouchUpInside += (sender, e) =>
            {
                this.lblText.Text = "輸入了" + txtField.Text;
            };

            UISlider slider = new UISlider(new RectangleF(0, 0, MyView.Frame.Width - 20, 50));
            slider.MinValue = 0.0f;
            slider.MaxValue = 100.0f;
            slider.SetValue(20.0f, false);
            slider.ValueChanged += (sender, e) =>
            {
                this.lblText.Text = string.Format("Silder數值為{0}", ((int)slider.Value).ToString());
            };
            MyView.AddSubview(slider);


            var mySwitch= new UISwitch(new RectangleF(0, 0, 100, 30));
            mySwitch.ValueChanged += (sender, e) =>
            {
                this.lblText.Text = string.Format("UISwitch數值為{0}", mySwitch.On ? "ON" : "OFF");
            };

            var progress = new UIProgressView(new RectangleF(0, 0, MyView.Frame.Width - 20, 100));
            progress.Style = UIProgressViewStyle.Default;

            var img = new UIImageView(new RectangleF(0, 0, 200, 200));
            img.Image = UIImage.FromBundle("flower.jpg");

            this.seg.ValueChanged += (sender, e) =>
          {
              this.lblText.Text = "選擇了" + this.seg.TitleAt(seg.SelectedSegment);
              slider.RemoveFromSuperview();
              mySwitch.RemoveFromSuperview();
              progress.RemoveFromSuperview();
              img.RemoveFromSuperview();
              flag = false;
              switch (seg.SelectedSegment)
              {
                  case 0:
                      MyView.AddSubview(slider);
                      break;
                  case 1:
                      MyView.AddSubview(mySwitch);
                      break;
                  case 2:
                      flag = true;
                      progress.Progress = 0;
                      MyView.AddSubview(progress);
                      ChangeProgress(progress);
                      break;
                  case 3:
                      MyView.AddSubview(img);
                      break;
                      
              }

          };

        }
        bool flag;
        private async void ChangeProgress(UIProgressView progress)
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (!flag)
                    break;
                await Task.Delay(500);
                progress.Progress = (float)(i + 1) / 10;
                lblText.Text = string.Format("Progress數值為{0} %", (progress.Progress * 100).ToString());
            }
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







        partial void UIButton41_TouchUpInside(UIButton sender)
        {
            this.lblText.Text = "按下了" + sender.TitleLabel.Text;
        }




    }
}