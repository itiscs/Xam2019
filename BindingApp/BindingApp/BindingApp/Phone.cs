using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BindingApp
{
    [Table("Phones")]
    public class Phone
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
    }
}
