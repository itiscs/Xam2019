using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            txtHello.Text = "Hello, world!";
           
            


        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }
    }
}
