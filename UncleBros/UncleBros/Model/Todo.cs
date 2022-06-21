using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBros.Model
{
    [Table("Todo")]
    public class Todo
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Title { get; set; }
    }
}
