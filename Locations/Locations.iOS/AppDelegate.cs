using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.Azure.Mobile;


namespace Locations.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            MobileCenter.Configure("0fe83814-e20f-4c9f-b73e-3723c086e9a1");

            //I SURE HOPE THIS WORKS
            //PLEASE WORK!!!
            //NEW COMMENT
            //PLEASE WORK ON FRIDAY!
            //PLEASE WORK TODAY TOO!
            //THIS IS A NEW COMMENT

#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

//TODO:  Need to do more cool stuff here
           
                
            return base.FinishedLaunching(app, options);
        }
    }
}
