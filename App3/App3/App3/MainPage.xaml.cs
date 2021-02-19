using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            // await DisplayAlert("title", txtName.Text,"OK");
            await Navigation.PushAsync(new Page3());
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyTabbedPage());

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetailPage1());


        }
    }
}
