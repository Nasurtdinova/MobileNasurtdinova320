using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNasurtdinova320.SQL_Lite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestNasurtdinova320
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrsPage : ContentPage
    {
        public RegistrsPage()
        {
            InitializeComponent();
        }

        private async void btn_Register(object sender, EventArgs e)
        {
            User user = new User()
            {
                Login = loginEntry.Text,
                Email = emailEntry.Text,
                Password = passwordEntry.Text
            };
            if (!String.IsNullOrEmpty(user.Email) && !String.IsNullOrEmpty(user.Password))
            {
                if (passwordEntry.Text == password2Entry.Text)
                    App.Database.SaveUser(user);
                else
                    await DisplayAlert("Ошибка", "Пароли не совпадают", "ОК");
            }
            await this.Navigation.PopAsync();
        }
    }
}