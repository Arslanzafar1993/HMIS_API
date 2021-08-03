using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_health_facilty_category
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool? status { get; set; }
    }
}
