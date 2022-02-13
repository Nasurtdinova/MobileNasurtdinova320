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
            var user = App.Database.GetUsers().Where(u => u.Login == loginEntry.Text && u.Password == passwordEntry.Text).ToList().FirstOrDefault();
            if (!String.IsNullOrEmpty(user.Email) && !String.IsNullOrEmpty(user.Password))
            {
                if (user != null)
                {
                    var ProjectsPage = new ProjectsPage();
                    NavigationPage.SetHasBackButton(ProjectsPage, false);
                    await Navigation.PushAsync(new ProjectsPage());
                }
                else
                {
                    await DisplayAlert("Ошибка", "Неверные данные", "ОК");
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Введите данные", "ОК");
            }
            
        }
    }
}
