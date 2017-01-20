using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Locations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Button click handler
            DemoButton.Clicked += DemoButton_Clicked;
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Demo mode");
            App.Instance.ClearNavigationAndGoToPage(new HomePage());
        }
    }
}
