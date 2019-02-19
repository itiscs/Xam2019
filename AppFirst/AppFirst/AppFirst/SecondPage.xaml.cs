using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFirst
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
        }
        public SecondPage(string txt):this()
        {
            
            txtName.Text = txt;
            if (App.Current.Resources.ContainsKey("Age"))
            {
                int age = (int) App.Current.Resources["Age"];
                txtName.Text = $"{txt} {age}";  
            }
            
        }
    }
}