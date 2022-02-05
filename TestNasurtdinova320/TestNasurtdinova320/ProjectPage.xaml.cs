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
    public partial class ProjectPage : TabbedPage
    {
        public ProjectPage(string title)
        {
            InitializeComponent();
            titles.Text = title;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Project project = new Project();
            EditProjectPage projectPage = new EditProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }
    }
}