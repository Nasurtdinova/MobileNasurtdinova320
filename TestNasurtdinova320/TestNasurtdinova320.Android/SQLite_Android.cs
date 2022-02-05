using System;
using System.IO;
using Xamarin.Forms;
using TestNasurtdinova320.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace TestNasurtdinova320.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}