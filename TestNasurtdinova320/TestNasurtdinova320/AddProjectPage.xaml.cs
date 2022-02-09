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
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private async void SaveProject(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (!String.IsNullOrEmpty(project.Name))
            {
                App.Database.SaveItem(project);
            }
            await this.Navigation.PopAsync();         
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}