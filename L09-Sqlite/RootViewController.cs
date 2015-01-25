using System;
using System.Drawing;

using Foundation;
using UIKit;
using L09_Sqlite.Service;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace L09_Sqlite
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

      
        MySource source;
        MyService service;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            service=new MyService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "DB.Db"));
            List<Info> items = new List<Info>();
            if (service.CoutInfo() == 0)
            {
                items.Add(new Info() { Age = "12", Name = "Eco" });
                items.Add(new Info() { Age = "13", Name = "Lydia" });
                items.Add(new Info() { Age = "14", Name = "Steven" });
                items.Add(new Info() { Age = "15", Name = "Ben" });
                items.Add(new Info() { Age = "17", Name = "Terry" });
                items.Add(new Info() { Age = "18", Name = "KFC" });
                items.Add(new Info() { Age = "92", Name = "Moss" });
                items.Add(new Info() { Age = "53", Name = "Toyota" });
                items.Add(new Info() { Age = "122", Name = "BMW" });
                items.Add(new Info() { Age = "12", Name = "Zent" });
                service.AddData(items.ToArray());
            }


            source = new MySource()
            {
                Items = items
            };
            MyTable.Source = source;
        
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            this.txtKey.ResignFirstResponder();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            var c = segue.DestinationViewController as AddInfoViewController;
            if (c.HasEvent == false)
            {
                c.OnAdd += (obj, info) =>
                {
                    this.source.Items.Add(info);
                    service.AddData(info);
                    MyTable.ReloadData();
                };
                c.HasEvent = true;
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

        partial void UIButton33_TouchUpInside(UIButton sender)
        {
            var result=service.Query(this.txtKey.Text);
            this.source.Items = result.ToList();
            MyTable.ReloadData();
        }
    }

    public class MySource : UITableViewSource
    {
        public List<Info> Items { get; set; }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell=tableView.DequeueReusableCell("MyCell") as MyCell;
            cell.SetData(Items[indexPath.Row]);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Items.Count;
        }
    }
}