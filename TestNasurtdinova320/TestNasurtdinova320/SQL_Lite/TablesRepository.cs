using System.Collections.Generic;
using SQLite;
using TestNasurtdinova320.SQL_Lite;

namespace TestNasurtdinova320
{
    public class TablesRepository
    {
        SQLiteConnection database;
        public TablesRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
            database.CreateTable<Project>();   
        }
        public IEnumerable<Project> GetProjects()
        {
            return database.Table<Project>().ToList();
        }
        public Project GetProject(int id)
        {
            return database.Get<Project>(id);
        }
        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }
        public int SaveProject(Project item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }
        public User GetUser(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteUser(int id)
        {
            return database.Delete<User>(id);
        }
        public int SaveUser(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
