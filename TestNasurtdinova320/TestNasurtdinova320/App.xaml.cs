using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Font")]
namespace TestNasurtdinova320
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "projects.db";
        public static TablesRepository database;
        public static TablesRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new TablesRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
