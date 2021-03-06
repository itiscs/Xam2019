﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public Phone CurrentPhone { get; set; }
        public ItemPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public ItemPage(Phone currentPhone)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CurrentPhone = currentPhone;
            this.BindingContext = CurrentPhone;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var phone = (Phone)BindingContext;
            if (!String.IsNullOrEmpty(phone.Title))
            {
                await App.Database.SaveItemAsync(phone);
            }
            await Navigation.PopAsync();

        }
    }
}