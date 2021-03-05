using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static PhoneRepository database;
        public static  PhoneRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PhoneRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
