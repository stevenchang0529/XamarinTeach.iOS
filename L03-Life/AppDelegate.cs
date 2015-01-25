using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace L03_Life
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public string Value { get;set; }

        public override UIWindow Window
        {
            get;
            set;
        }

        public AppDelegate()
        {
            Value = "First Set";
        }


        //應用程式啟動時執行，包含每次APP回到執行狀態皆會觸發
        public override void OnActivated(UIApplication application)
        {
            Console.WriteLine("OnActivated");

        }

        //
        // This method is invoked when the application is about to move from active to inactive state.
        //
        // OpenGL applications should use this method to pause.
        //APP即將進入背景狀態  EX:暫停執行的任務、及活動
        public override void OnResignActivation(UIApplication application)
        {
            Console.WriteLine("OnResignActivation");
            var nav = this.Window.RootViewController as UINavigationController;
            var controller = nav.TopViewController as L03LifeViewController;
            controller.Test("OnResignActivation SET");
        }

        // This method should be used to release shared resources and it should store the application state.
        // If your application supports background exection this method is called instead of WillTerminate
        // when the user quits.
        //APP進入背景狀態 EX:保存數據、釋放資源，注意這裡僅只有5秒鐘的執行時間限制，超過5秒時應用程式會異常退出
        public override void DidEnterBackground(UIApplication application)
        {
            Console.WriteLine("DidEnterBackground");
        }

        // This method is called as part of the transiton from background to active state.
        //APP由背景重新啟動，執行完後會接到OnActivated
        public override void WillEnterForeground(UIApplication application)
        {
            Console.WriteLine("WillEnterForeground");
        }

        // This method is called when the application is about to terminate. Save data, if needed. 
        //應用程式已結束
        public override void WillTerminate(UIApplication application)
        {
            Console.WriteLine("WillTerminate");
        }
    }
}