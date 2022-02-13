using Android.App;
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
    [Activity(NoHistory = true)]
    public partial class ProjectsPage : ContentPage
    {
        public string[] projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();            
        }

        protected override void OnAppearing()
        {
            projectsList.ItemsSource = App.Database.GetProjects();
            base.OnAppearing();
        }

        private async void ProjectsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            ProjectPage projectPage = new ProjectPage();
            projectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(projectPage);
        }

        private async void AddProject(object sender, EventArgs e)
        {         
            await Navigation.PushAsync(new AddProjectPage());
        }
       
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}