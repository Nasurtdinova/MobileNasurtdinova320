using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestNasurtdinova320
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavPage : ContentPage
    {
        public GlavPage()
        {
            InitializeComponent();
           
        }

        private async void Button_Registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrsPage());
        }

        private async void Button_Login_Clicked(object sender, EventArgs e)
        {
            //var ProjectsPage = new ProjectsPage();
            //NavigationPage.SetHasBackButton(ProjectsPage, false);
            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}