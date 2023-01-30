using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmaelOrdonez_EvluacionP3.Models
{
    [Table("api")]
    public class ApiClass
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(250)]
        public string anime_name { get; set; }
        public string url { get; set; }
    }
}
