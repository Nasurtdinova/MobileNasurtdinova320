using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestNasurtdinova320.SQL_Lite
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Unique]
        public string Email { get; set; }
    }
}
