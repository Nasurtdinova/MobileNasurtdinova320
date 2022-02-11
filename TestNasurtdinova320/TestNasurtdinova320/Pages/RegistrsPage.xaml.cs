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
    public partial class RegistrsPage : ContentPage
    {
        public RegistrsPage()
        {
            InitializeComponent();
        }

        private async void btn_Register(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}