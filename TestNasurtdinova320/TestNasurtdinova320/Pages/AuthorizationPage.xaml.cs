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

        private void Button_Login_Clicked(object sender, EventArgs e)
        {
            var user = App.Database.GetUsers().Where(u => u.Login == loginEntry.Text && u.Password == passwordEntry.Text).ToList().FirstOrDefault();
            if (user != null)
            {
                var ProjectsPage = new ProjectsPage();
                NavigationPage.SetHasBackButton(ProjectsPage, false);
                Navigation.PushAsync(new ProjectsPage());
            }
            else
            {
                DisplayAlert("Ошибка", "Неверные данные", "ОК");
            }

        }
    }
}
