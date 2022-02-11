﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestNasurtdinova320
{
    [Table("Images")]
    public class Photo
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [Unique]
        public string Name { get; set; }
        public string PathImage { get; set; }
    }
}