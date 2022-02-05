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
            projectsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void projectsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            ProjectPage projectPage = new ProjectPage(selectedProject.Name);
            projectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(projectPage);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Project project = new Project();
            AddProjectPage projectPage = new AddProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }

        
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}