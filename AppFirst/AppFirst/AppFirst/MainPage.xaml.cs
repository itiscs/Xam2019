using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFirst
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private int k = 0;

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            BoxView box = new BoxView()
            {
                WidthRequest = 100,
                HeightRequest = 100
            };
            Random r = new Random();
            box.Margin = new Thickness(r.Next(40));

            if (k % 3 == 0)
                box.Color = Color.Red;
            else if (k % 3 == 1)
                box.Color = Color.Green;
            else
                box.Color = Color.Blue;
            k++;

            stk.Children.Add(box);

        }

        private void BtnSecond_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["Age"] = int.Parse(txtAge.Text);

            Navigation.PushAsync(new SecondPage(userName.Text));
            
        }
    }
}
