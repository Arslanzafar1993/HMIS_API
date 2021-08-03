using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_next_of_kin
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? created { get; set; }
        public bool? status { get; set; }
    }
}
