using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using System.Linq;
namespace L12_Location
{
    
    public partial class L12LocationViewController : UIViewController
    {
        public L12LocationViewController(IntPtr handle)
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
            CLLocationManager location = new CLLocationManager();
            CLGeocoder geocoder = new CLGeocoder();
            

            location.DistanceFilter = 10f;//設定裝置每移動10公尺更新定位資訊
            location.HeadingFilter = 5;//當角度變更超過5度時才更新資訊
            location.LocationsUpdated += async (sender, e) =>
            {
                var newData=e.Locations.Last();
                this.lat.Text = "緯度:" + newData.Coordinate.Latitude.ToString();
                this.lon.Text = "經度:" + newData.Coordinate.Longitude.ToString();
                this.alt.Text = "高度:" + newData.Altitude.ToString();//高度資訊

                var result=await geocoder.ReverseGeocodeLocationAsync(newData);
                this.address.Text =
                    result[0].AddressDictionary["Country"].ToString() +
                    result[0].AddressDictionary["City"].ToString() +
                    result[0].SubLocality +
                    result[0].AddressDictionary["Street"].ToString();
            };

            location.UpdatedHeading += (sender, e) =>
            {
                this.head.Text = e.NewHeading.TrueHeading.ToString();//定位取得方向角度-- 北為0度順時針計算
            };

            location.StartUpdatingHeading();
            location.StartUpdatingLocation();

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