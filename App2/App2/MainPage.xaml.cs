using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            button.Clicked += Button_ClickedAsync;
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            string name = entry.Text;
            await DisplayAlert("Hi there", $"Hello {name}", "OK");
        }
    }
}
