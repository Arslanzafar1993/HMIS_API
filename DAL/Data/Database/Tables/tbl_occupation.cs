using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_occupation
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? created { get; set; }
        public bool? status { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
