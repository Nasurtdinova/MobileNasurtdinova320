using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestNasurtdinova320
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrsPage());
        }

        private async void Button_Login_Clicked(object sender, EventArgs e)
        {
           var ProjectsPage = new ProjectsPage();
            NavigationPage.SetHasBackButton(ProjectsPage, false);
            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}
