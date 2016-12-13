using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace Locations.Android
{
    [Activity(Label = "Locations.Android", 
        MainLauncher = true, 
        Icon = "@drawable/icon",
         ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            MobileCenter.Configure("800c182c-eab3-4e49-9f26-51b3a0a05bf4");

            LoadApplication(new App());

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            
        }
    }
}

