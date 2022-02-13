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
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите удалить {project.Name}?", "Удалить", "Отмена"))
            {              
                App.Database.DeleteProject(project.Id);
                await Navigation.PushAsync(new ProjectsPage());
            }      
        }

        private async void SaveProject(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите изменить {project.Name}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.Name))
                {
                    App.Database.SaveProject(project);
                }
                await this.Navigation.PopAsync();
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}