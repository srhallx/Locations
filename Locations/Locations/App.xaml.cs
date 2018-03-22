using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Locations
{
    public partial class App : Application
    {
        public static App Instance;

        public App()
        {
            InitializeComponent();
            Instance = this;

            MobileCenter.Start(typeof(Analytics), typeof(Crashes));

			MainPage = new NavigationPage(new Locations.MainPage());
        }

        public void ClearNavigationAndGoToPage(ContentPage page)
        {
            MainPage = new NavigationPage(page);
        }
 
    protected override void OnStart()
        {
            // Handle when your app starts!!!
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
