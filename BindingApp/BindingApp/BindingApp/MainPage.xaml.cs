using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingApp
{
    public partial class MainPage : ContentPage
    {
        public List<Phone> Phones { get; set; }
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Phones = new List<Phone>
            //{
            //    new Phone {Title="Galaxy S21", Company="Samsung", Price=48000, ImagePath="car.png" },
            //    new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="user.png" },
            //    new Phone {Title="HTC U Ultra", Company="HTC", Price=42000, ImagePath="car.png" },
            //    new Phone {Title="iPhone 11", Company="Apple", Price=92000, ImagePath="images.jpg" },
            //    new Phone {Title="Galaxy S21", Company="Samsung", Price=48000, ImagePath="user.png" },
            //    new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="user.png" },
            //    new Phone {Title="HTC U Ultra", Company="HTC", Price=42000, ImagePath="car.png" },
            //    new Phone {Title="iPhone 11", Company="Apple", Price=92000, ImagePath="user.png" }

            //};
            //this.BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            phonesList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Phone selectedPhone = e.Item as Phone;
            var phonePage = new ItemPage();
            //phonePage.BindingContext = phonePage;
            await Navigation.PushAsync(new ItemPage(selectedPhone));
            //if (selectedPhone != null)
            //    await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Phone friend = new Phone();
            var friendPage = new ItemPage()
            {
                BindingContext = friend
            };
            await Navigation.PushAsync(friendPage);
        }
    }
}
