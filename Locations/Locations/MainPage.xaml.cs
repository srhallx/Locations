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

            DemoButton.Clicked += DemoButton_Clicked;
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new HomePage());
        }
    }
}
