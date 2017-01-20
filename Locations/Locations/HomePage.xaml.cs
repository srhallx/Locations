using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Locations
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MyEntry.TextChanged += MyEntry_TextChanged;
            MyEntry.Keyboard = Keyboard.Text;

        }

        private void MyEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MyEntry.Text.Length > 0)
            {
                Pictogram.Text = MyEntry.Text;
                MyEntry.Text = "";
                MyEntry.Unfocus();
            }

        }
    }
}
